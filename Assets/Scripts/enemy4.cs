using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4 : MonoBehaviour {

    System.Random rnd;
    float x;
    float y;
    public Vector2 coords;
    GameObject spawner;

    float timer;
    public float movespeed;
    public bool isLerping = false;
    public Vector2 startPos;
    public float timesince;
    public float timestart;
    public float percent;
    bool ini = false;

    // Use this for initialization
    void Start()
    {
        rnd = new System.Random();
        coords = new Vector2(0, 0);
        timer = Time.time;
        spawner = GameObject.FindWithTag("spawn");
        generateCoords();
        transform.position = coords;

    }

    // Update is called once per frame
    void Update()
    {
        if(!ini)
        {
            generateCoords();
            transform.position = coords;
            ini = true;
        }
        
    }

    void generateCoords()
    {
        x = spawner.GetComponent<rng>().rngget(-4, 5);
        y = spawner.GetComponent<rng>().rngget(2, 8);

        coords.Set(x, y);
    }

    
}
