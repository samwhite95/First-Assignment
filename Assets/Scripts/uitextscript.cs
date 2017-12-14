using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uitextscript : MonoBehaviour {
    Text info;
    int health;
    int lives;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("rplayer");
        info = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        lives = player.GetComponent<health>().lives;
        health = player.GetComponent<health>().HP;

        info.text = "Health: " + health + "\n" + "Lives: " + lives;
	}
}
