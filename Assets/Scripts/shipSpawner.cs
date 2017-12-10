using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipSpawner : MonoBehaviour {
    public float spawnRate;
    float lastSpawn = 0;
    public GameObject enemy;
    public GameObject enemy2;
    public Text enemyText;
    int counter = 0;
    public int currentShips = 0;
    public int waveNum;

    public int maxShips;

    public int maxShips2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        switch(waveNum)
        {
            case 1:
                wave1();
                break;

            case 2:
                wave2();
                break;
        }
        
	}

    void spawnShips(GameObject ship, int max)
    {
        if ((Time.time > spawnRate + lastSpawn) && counter <= max)
        {
            Instantiate(ship, transform.position, transform.rotation);
            lastSpawn = Time.time;
            counter++;
            currentShips++;
        }
    }

    void wave1()
    {
        spawnShips(enemy, maxShips);

        if (currentShips == 0 && counter > 0)
        {
            waveNum++;
            counter = 0;
        }
    }

    void wave2()
    {
        spawnShips(enemy2, maxShips2);

        if (currentShips == 0 && counter > 0)
        {
            waveNum++;
            counter = 0;
        }
    }





}
