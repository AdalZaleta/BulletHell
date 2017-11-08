using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public GameObject Options_pan;

	public Slider Master;
	public Slider SFX;
	public Slider Music;

	public float Master_sound;
	public float SFX_sound;
	public float Music_sound;

	// Use this for initialization
	void Start () {
		Options_pan.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Master_sound = Master.value;
		SFX_sound = SFX.value;
		Music_sound = Music.value;
	}

	public void Play()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Options()
	{
		Options_pan.SetActive (true);
	}

	public void Back()
	{
		Options_pan.SetActive (false);
	}
}
