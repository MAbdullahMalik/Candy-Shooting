using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundController : MonoBehaviour {
	public List<AudioSource> listSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void MusicOn(){
		listSound [0].volume = 1;
	}
	public void MusicOff(){
		listSound [0].volume = 0;
	}
	public void SoundOn(){
		listSound [1].volume = 1;
	}
	public void SoundOff(){
		listSound [1].volume = 0;
	}

}
