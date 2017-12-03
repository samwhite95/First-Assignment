using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletLogic : MonoBehaviour {

    public float speed;
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
		//test
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 movement = new Vector2(0f, -speed);
        rb2d.velocity = movement * Time.deltaTime;
		
		
	}
	void OnBecameInvisible()
		{
			Destroy(gameObject);
		}
}
