using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {
    Rigidbody2D rb2d;
    // Use this for initialization
    public string name;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        name = gameObject.name;
    }
	
	// Update is called once per frame
	void Update () {
        rb2d.AddForce(Vector2.down);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        collision.GetComponent<PlayerController>().powerUP(name);

        Destroy(gameObject);
    }
}
