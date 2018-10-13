using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameObject[] carts;

	// Use this for initialization
	void Start () {
        carts = GameObject.FindGameObjectsWithTag("Cart");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
