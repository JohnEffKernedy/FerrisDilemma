using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour {

    Slider slider;

	// Use this for initialization
	void Start () {
        slider = gameObject.GetComponent<Slider>();
        slider.value = FindObjectOfType<MusicSingleton>().Volume;
        slider.onValueChanged.AddListener(delegate { FindObjectOfType<MusicSingleton>().setVolume(slider.value); });
	}

	// Update is called once per frame
	void Update () {
		
	}
}
