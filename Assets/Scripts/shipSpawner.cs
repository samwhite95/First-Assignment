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
    public int maxShips;
    int counter = 0;
    public int currentShips = 0;
    public int waveNum;

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

    void spawnShips(GameObject ship)
    {
        if ((Time.time > spawnRate + lastSpawn) && counter <= maxShips)
        {
            Instantiate(ship, transform.position, transform.rotation);
            lastSpawn = Time.time;
            counter++;
            currentShips++;
        }
    }

    void wave1()
    {
        spawnShips(enemy);

        if (currentShips == 0 && counter > 0)
        {
            waveNum++;
            counter = 0;
        }
    }

    void wave2()
    {
        spawnShips(enemy2);

        if (currentShips == 0 && counter > 0)
        {
            waveNum++;
            counter = 0;
        }
    }





}
