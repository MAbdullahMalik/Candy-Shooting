using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
	public UI2DSprite btSound;
	public UI2DSprite btNoSound;
	public UI2DSprite btMusic;
	public UI2DSprite btNoMusic;
	public UI2DSprite btHelp;
	public SoundController soundController;
	public TweenPosition tweenPos;
	public TweenPosition tweenPosHelp;
	// Use this for initialization
	void Awake(){
		tweenPos.enabled = false;
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ButtonSound(){
		btSound.enabled = false;
		btNoSound.enabled = true;
		soundController.SoundOff ();
	}
	public void ButtonNoSound(){
		btSound.enabled = true;
		btNoSound.enabled = false;
		soundController.SoundOn ();
	}
	public void ButtonMusic(){
		btMusic.enabled = false;
		btNoMusic.enabled = true;
		soundController.MusicOff();
	}
	public void ButtonNoMusic(){
		btMusic.enabled = true;
		btNoMusic.enabled = false;
		soundController.MusicOn();
	}
	public void ButtonHelp(){
		tweenPos.enabled = true;
		tweenPos.Play ();
	}
	public void ButtonBack(){
		tweenPos.enabled = false;
		tweenPosHelp.enabled = true;
		tweenPosHelp.Play();
		Debug.Log ("?");
	}
	public void FinishMoveHelp(){

	}

}
