using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour {

	private float delay;

	// Use this for initialization
	void Start () {
		delay = Random.Range (1.0f, 3.0f);
		StartCoroutine (Load ());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.back * 5.0f);
	}

	IEnumerator Load()
	{
		yield return new WaitForSeconds (delay);
		SceneManager.LoadSceneAsync ("HUD", LoadSceneMode.Additive);
		SceneManager.UnloadSceneAsync ("LoadScreen");
	}
}
