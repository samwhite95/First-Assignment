using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;
    public GameObject projectile;
    public Transform firepoint1;
    public Transform firepoint2;
    public int whichGun;
    public float fireSpeed;
    private float lastShot = 0f;
	float moveVertical;
	float moveHorizontal;


    void fire()
    {
        if (Time.time > fireSpeed + lastShot)
        {
            if (whichGun == 0)
            {
                Instantiate(projectile, firepoint1.position, firepoint1.rotation);
                whichGun = 1;
            }
            else
            {
                Instantiate(projectile, firepoint2.position, firepoint2.rotation);
                whichGun = 0;
            }

            lastShot = Time.time;
        }
    }
	
	void checkBounds()
	{
		if(transform.position.x > 4.5)
		{
			transform.position = new Vector2(4.5f, transform.position.y);
		}
		if(transform.position.x < -4.5)
		{
			transform.position = new Vector2(-4.5f, transform.position.y);
		}
		if(transform.position.y < -6)
		{
			transform.position = new Vector2(transform.position.x, -6);
		}
		if(transform.position.y > 0)
		{
			transform.position = new Vector2(transform.position.x, 0);
		}
	}
	
	void movePlayer()
	{
		moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = (movement * speed);
	}

    

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		movePlayer();
        
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            fire();
        }
		
		checkBounds();		
    }


}
