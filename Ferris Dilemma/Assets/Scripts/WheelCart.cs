using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelCart : MonoBehaviour {
    public int counter = 0;
    public int badGuys = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BadGuy"))
        {
            badGuys++;
        }
        if (collision.CompareTag("Guest"))
        {
            counter++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("BadGuy"))
        {
            badGuys--;
        }

        if (collision.CompareTag("Guest"))
        {
            counter--;
        }
    }
}
