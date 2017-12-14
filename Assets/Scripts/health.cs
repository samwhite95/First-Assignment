using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour {

	public int HP;
    public float flashTimer;
    GameObject spawner;
    public GameObject up1;
    public GameObject dmg;
    public GameObject fireup;
    public GameObject heal;
    public GameObject speed;
    public int percentagePowerUp;
    Quaternion up;
    public int lives;
    int hp2;
    string sceneName;
    Scene currentScene;

    // Use this for initialization
    void Start () {

        spawner = GameObject.FindWithTag("spawn");
        hp2 = HP;
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
	
	// Update is called once per frame
	void Update () {



	}

	public void takeDamage(int amount)
    {
        HP -= amount;
        StartCoroutine(flashRed());
        if(HP <= 0)
        {
            if (lives <= 0)
            {
                pickup(percentagePowerUp);
                //transform.Find("spawner").GetComponent<shipSpawner>().currentShips--; //finds the spawner object, accesses the counter for the current enemy count, and decrements it
                if (gameObject.layer == LayerMask.NameToLayer("enemy"))
                {
                    if (spawner != null)
                    {
                        if(sceneName == "Assessment")
                        {
                            spawner.GetComponent<shipSpawner>().currentShips--;
                        }
                        if(sceneName == "level2")
                        {
                            spawner.GetComponent<spawnerlvl2>().currentShips--;
                            
                        }
                        
                    }
                    if (transform.parent != null)
                    {
                        Destroy(transform.parent.gameObject);
                    }
                }


                Destroy(gameObject);

            }
            lives--;
            HP = hp2;
        }
    }

    IEnumerator flashRed()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.3f);
        GetComponent<SpriteRenderer>().color = Color.white;


    }

    void pickup(int perc)
    {
        System.Random ran = new System.Random();
        
        int chance = ran.Next(0, 11);
        if (perc >= chance)
        {
            chance = ran.Next(0, 5);
            switch (chance)
            {
                case 1:
                    Instantiate(up1, transform.position, up);
                    break;
                case 2:
                    Instantiate(dmg, transform.position, up);
                    break;
                case 3:
                    Instantiate(fireup, transform.position, up);
                    break;
                case 4:
                    Instantiate(heal, transform.position, up);
                    break;
                case 0:
                    Instantiate(speed, transform.position, up);
                    break;

            }
        }
    }
}
