using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text badGuyText;
    private GameObject[] carts;

    public Transform badGuy;
    int guests = 0;
    int badGuys = 0;
	// Use this for initialization
	void Start () {
        carts = GameObject.FindGameObjectsWithTag("Cart");
	}
	
	// Update is called once per frame
	void Update () {
        guests = 0;
        badGuys = 0;
		for(int i = 0; i < carts.Length; i++)
        {
            guests += carts[i].GetComponent<WheelCart>().counter;
            badGuys += carts[i].GetComponent<WheelCart>().badGuys;
        }
        scoreText.text = "Guests Left: " + guests;
        badGuyText.text = "Bad Guys Left: " + badGuys;

        if(badGuy.position.y < -150 && badGuys == 0)
        { 
            SceneManager.LoadScene("FerrisWheel2");
        }
	}
}
