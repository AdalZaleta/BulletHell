﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset ()
	{
		SceneManager.LoadScene ("main");
	}
}
