﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("FerrisWheel0");
    }

    public void ShowTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ShowCredits()
    {

    }
}
