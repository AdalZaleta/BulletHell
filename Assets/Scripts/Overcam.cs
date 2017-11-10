using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overcam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Retry ()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Quit ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
