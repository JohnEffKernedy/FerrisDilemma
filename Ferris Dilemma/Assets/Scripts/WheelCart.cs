using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelCart : MonoBehaviour {
    public int counter = 0;
    public int badGuys = 0;

    public AudioSource PunchSound;

    private float originalPitch;
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
            PlayPunchSound(collision.GetComponent<Rigidbody2D>().velocity.magnitude);
            badGuys++;
        }
        if (collision.CompareTag("Guest"))
        {
            PlayPunchSound(collision.GetComponent<Rigidbody2D>().velocity.magnitude);
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

    private void PlayPunchSound(float velocity)
    {
        if (PunchSound.isPlaying) return;
        if (velocity < 8) return;
        velocity = Mathf.Clamp(velocity, 8, 16);
        float pitchChange = 0.5f + (velocity / 16f);
        PunchSound.pitch = pitchChange;
        PunchSound.Play();
    } 
}
