using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipSpawner : MonoBehaviour {
    public float spawnRate;
    float lastSpawn = 0;
    public GameObject enemy;
    public GameObject healthBar;
    public Text enemyText;
    public int maxShips;
    int counter = 0;
    public int currentShips = 0;
    int waveNum = 1;

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
        }
        
	}

    void wave1()
    {
        if ((Time.time > spawnRate + lastSpawn) && counter <= maxShips)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            lastSpawn = Time.time;
            counter++;
            currentShips++;
            if(currentShips == 0)
            {
                waveNum++;
            }
        }
    }

    void wave2()
    {

    }





}
