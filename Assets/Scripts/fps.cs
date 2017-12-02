using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour {

    public int framerate;
	// Use this for initialization
	void Start () {
        QualitySettings.vSyncCount = 1;
        //Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.targetFrameRate != framerate)
        {
            Application.targetFrameRate = framerate;
        }
	}
}
