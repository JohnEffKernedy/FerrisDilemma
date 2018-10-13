using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ferriswheel : MonoBehaviour {

    public float rotationSpeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed);
        }

        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                transform.Rotate(Vector3.forward, rotationSpeed);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                transform.Rotate(Vector3.forward, -rotationSpeed);
            }
        }

        
    }
}
