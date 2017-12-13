using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rng : MonoBehaviour {
    System.Random rnd;
    int num;
    // Use this for initialization
    void Start () {
        rnd = new System.Random();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int rngget(int min, int max)
    {
        num = rnd.Next(min,max);
        if(num == rnd.Next(min,max))
        {
            num = rnd.Next(min,max);
        }
        return num;
    }
}
