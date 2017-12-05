using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

	public int HP;
    public float flashTimer;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {



	}

	public void takeDamage()
    {
        HP -= 1;
        StartCoroutine(flashRed());
        if(HP == 0)
        {
			transform.Find("spawner").GetComponent<shipSpawner>().currentShips--; //finds the spawner object, accesses the counter for the current enemy count, and decrements it
            Destroy(transform.parent.gameObject);
            

        }
    }

    IEnumerator flashRed()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.3f);
        GetComponent<SpriteRenderer>().color = Color.white;


    }
}
