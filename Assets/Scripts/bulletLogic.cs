using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLogic : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 movement = new Vector2(0f, speed);
        rb2d.velocity = movement * Time.deltaTime;
		
		
	}
	void OnBecameInvisible()
		{
			Destroy(gameObject);
		}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<health>().takeDamage();
        
        Destroy(gameObject);
    }

}
