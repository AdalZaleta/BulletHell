using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject Pause_pan;

	// Use this for initialization
	void Start () {
		Pause_pan.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause_pan.SetActive (true);
		}
	}

	public void Continue()
	{
		Pause_pan.SetActive (false);
	}

	public void Quit()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
