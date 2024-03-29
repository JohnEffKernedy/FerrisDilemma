﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSingleton : MonoBehaviour {

    public static MusicSingleton instance = null;
    public AudioSource music_loop;
    public float Volume = 1f;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setVolume(float vol)
    {
        Volume = vol;
        music_loop.volume = Volume;
    }
}
