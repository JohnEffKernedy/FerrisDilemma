using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour {

    public Text scoreText;
    public Text badGuyText;
    public Text winText;
    private GameObject[] carts;

    public Transform[] badGuys;
    int guests = 0;
    int badGuysCount = 0;
	// Use this for initialization
	void Start () {
        carts = GameObject.FindGameObjectsWithTag("Cart");
	}
	
	// Update is called once per frame
	void Update () {
        guests = 0;
        badGuysCount = 0;
		for(int i = 0; i < carts.Length; i++)
        {
            guests += carts[i].GetComponent<WheelCart>().counter;
            badGuysCount += carts[i].GetComponent<WheelCart>().badGuys;
        }
        scoreText.text = "Guests Left: " + guests;
        badGuyText.text = "Bad Guys Left: " + badGuysCount;

        if(badGuysCount == 0)
        {
            for (int i = 0; i < badGuys.Length; i++)
            {
                if(! (badGuys[i].position.y < -150))
                {
                    return;
                }
            }
            winText.text = "You did it!";
        }
	}
}
