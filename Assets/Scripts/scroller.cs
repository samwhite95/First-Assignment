using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb2d;
    Vector3 backPOS = new Vector3(0, 0, 0);
    Vector2 movement = new Vector2(0, 0);
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


        /*backPOS = gameObject.transform.position;
        backPOS.y = backPOS.y - speed;*/
        movement.y = -speed * 10;
        rb2d.velocity = movement;
        if(gameObject.transform.position.y < -20)
        {
            backPOS.y = 20f;
            gameObject.transform.position = backPOS;

        }

        //

    }
}
