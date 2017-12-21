using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {
    public bool isStart;
    public bool isQuit;
    public bool isCredits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    private void OnMouseUp()
    {
        if (isStart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (isQuit)
        {
            Application.Quit();
        }
        if (isCredits)
        {
            SceneManager.LoadScene(4);
        }
    }
}
