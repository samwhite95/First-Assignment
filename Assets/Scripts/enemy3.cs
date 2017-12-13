using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour {
    System.Random rnd;
    float x;
    float y;
    public Vector2 coords;

    float timer;
    public float movespeed;
    public bool isLerping = false;
    public Vector2 startPos;
    public float timesince;
    public float timestart;
    public float percent;

    // Use this for initialization
    void Start () {
        rnd = new System.Random();
        coords = new Vector2(0, 0);
        timer = Time.time;
        
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.time > (timer + movespeed))
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
        x = rnd.Next(-5, 5);
        y = rnd.Next(2, 8);
        coords.Set(x, y);
    }

    void startLerp()
    {
        isLerping = true;
        startPos = transform.position;
        timestart = Time.time;
    }
}
