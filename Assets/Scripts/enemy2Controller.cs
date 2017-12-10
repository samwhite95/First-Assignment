using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2Controller : MonoBehaviour {

    public float flyspeed;

	// Use this for initialization
	void Start () {
        iTween.RotateTo(gameObject, iTween.Hash("y", 90f, "time", 0.2f));
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("enemy2"),
            "time", flyspeed,
            "easetype", iTween.EaseType.linear,
            "movetopath", false,
            "looptype", "loop"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
