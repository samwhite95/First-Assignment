﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipSpawner : MonoBehaviour {
    
    float lastSpawn = 0;
    public GameObject enemy;
    public GameObject enemy2;
    public Text enemyText;
    
    public int currentShips = 0;
    public int waveNum;

    public int maxShips;
    public int counter = 0;
    public float spawnRate;

    public int maxShips2;
    public int counter2 = 0;
    public float spawnRate2;

    bool swapships = false;

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

            case 3:
                wave3();
                break;
        }
        
	}

    void spawnShips(GameObject ship, int max, float rate, ref int count)
    {
        if ((Time.time > rate + lastSpawn) && count < max)
        {
            Instantiate(ship, transform.position, transform.rotation);
            lastSpawn = Time.time;
            count++;
            currentShips++;
            swapships = !swapships;
        }
    }

    void wave1()
    {
        spawnShips(enemy, maxShips, spawnRate, ref counter);

        if (currentShips == 0 && counter == maxShips)
        {
            waveNum++;
            counter = 0;
        }
    }

    void wave2()
    {
        spawnShips(enemy2, maxShips2, spawnRate2, ref counter2);

        if (currentShips == 0 && counter2 == maxShips2)
        {
            waveNum++;
            counter2 = 0;
        }
    }

    void wave3()
    {
        if(!swapships)
        {
            spawnShips(enemy, maxShips, spawnRate, ref counter);
        }
        if(swapships)
        {
            spawnShips(enemy2, maxShips2, spawnRate2, ref counter2);
        }
        if (currentShips == 0 && counter2 > 0)
        {
            waveNum++;
            counter2 = 0;
            counter = 0;
        }
    }





}
