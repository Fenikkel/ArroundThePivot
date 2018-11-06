using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestClick()
    {
        print("Button was clicked");
    }

    public void TestLoadScene()
    {
        SceneManager.LoadScene("Scene3");
    }
}
