using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyController : MonoBehaviour {

    // Use this for initialization
    bool animComp = false;
    public float fireSpeed;
    private float lastShot = 0f;
    public GameObject projectile;
    Quaternion zero = new Quaternion(0, 0, 0, 0);
    public GameObject ship;
    public float entranceSpeed;
    bool initialized = false;
    public float patrolSpeed;
    public const int maxHP = 100;
    public int currentHP = maxHP;
    public Text damageText;
    



    void Start()
    {
        

        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("path1"),
            "time", entranceSpeed,
            "easetype", iTween.EaseType.easeInSine,
            "orienttopath", true,
            "lookahead", 0.001,
            "looktime", 0.2f,
            "oncomplete", "initialize",
            "movetopath", false));

        

    }
    void initialize()
    {
        initialized = true;
        iTween.RotateTo(gameObject, iTween.Hash("x", 90f, "time", 0.2f));
        patrol();

    }

    void fire()
    {
        if (Time.time > fireSpeed + lastShot)
        {
            
            Instantiate(projectile, transform.position, zero);
            lastShot = Time.time;
        }
    }

    /*public void takedamage(int damage)
    {
        currentHP -= damage;
        ship.GetComponent<SpriteRenderer>().color = new Color(currentHP / 100f, currentHP / 100f, 1, 1);
    }*/

    void patrol()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("patrol"),
            "time", patrolSpeed,
            "easetype", iTween.EaseType.linear,
            "movetopath", false,
            "looptype", "loop"));
    }
    // Update is called once per frame
    void Update()
    {
        if (initialized == true)
        {
            fire();
            

        }
        
    }

    
}
