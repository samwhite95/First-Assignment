using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3spawn : MonoBehaviour {
    float lastSpawn = 0;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;


    public int currentShips = 0;
    public int waveNum;

    public int maxShips;
    public int counter = 0;
    public float spawnRate;

    public int maxShips2;
    public int counter2 = 0;
    public float spawnRate2;

    public int maxShips3;
    public int counter3 = 0;
    public float spawnRate3;

    public int maxShips4;
    public int counter4 = 0;
    public float spawnRate4;

    bool swapships = false;
    int swapshipsint = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        wave1();

    }

    void spawnShips(GameObject ship, int max, float rate, ref int count)
    {
        if ((Time.time > rate + lastSpawn) && count < max)
        {
            Instantiate(ship, transform.position, transform.rotation);
            lastSpawn = Time.time;
            count++;
            currentShips++;
            swapshipsint++;
            if(swapshipsint == 4)
            {
                swapshipsint = 0;
            }

        }
    }

    void wave1()
    {
        if (swapshipsint == 0 && counter <= maxShips)
        {
            spawnShips(enemy, maxShips, spawnRate, ref counter);
            
        }
        if (swapshipsint == 1 && counter2 <= maxShips2)
        {
            spawnShips(enemy2, maxShips2, spawnRate2, ref counter2);
            
        }
        if (swapshipsint == 2 && counter3 <= maxShips3)
        {
            spawnShips(enemy3, maxShips3, spawnRate3, ref counter3);
            
        }
        if (swapshipsint == 3 && counter4 <= maxShips4)
        {
            spawnShips(enemy4, maxShips4, spawnRate4, ref counter4);
            
        }

        if (currentShips == 0 && counter2 >= maxShips2 && counter >= maxShips && counter4 >= maxShips4)
        {
            waveNum++;
            counter2 = 0;
            counter = 0;
            Application.Quit();
        }
    }

    
}
