using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour {
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

    public float fireSpeed;
    private float lastShot = 0f;
    public GameObject projectile;
    Quaternion zero = new Quaternion(0, 0, 0, 0);

    // Use this for initialization
    void Start () {
        rnd = new System.Random();
        coords = new Vector2(0, 0);
        timer = Time.time;
        spawner = GameObject.FindWithTag("spawn");

    }
	
	// Update is called once per frame
	void Update () {

        fire();

		if(Time.time > (timer + movespeed + 1f))
        {
            generateCoords();
            startLerp();
            timer = Time.time;

        }
        if(isLerping)
        {
            timesince = Time.time - timestart;
            percent = timesince / movespeed;
            transform.position = Vector2.Lerp(startPos, coords, percent);
            if(percent >= 1f)
            {
                isLerping = false;
                
            }
        }
	}

    void generateCoords()
    {
        x = spawner.GetComponent<rng>().rngget(-4, 5);
        y = spawner.GetComponent<rng>().rngget(2, 8);
        
        coords.Set(x, y);
    }

    void startLerp()
    {
        isLerping = true;
        startPos = transform.position;
        timestart = Time.time;
    }
    void fire()
    {
        if (Time.time > fireSpeed + lastShot)
        {

            Instantiate(projectile, transform.position, zero);
            lastShot = Time.time;
        }
    }
}
