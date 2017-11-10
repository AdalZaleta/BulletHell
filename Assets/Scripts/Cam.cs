using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cam : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		SceneManager.LoadSceneAsync ("LoadScreen", LoadSceneMode.Additive);
		Screen.orientation = ScreenOrientation.Portrait;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void callBlink()
	{
		StartCoroutine (Blink (4));
	}

	IEnumerator Blink(int Bcount)
	{
		player.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		player.SetActive (true);
		Bcount--;
		if (Bcount != 0)
		{
			yield return new WaitForSeconds (0.1f);
			StartCoroutine (Blink(Bcount));
		}
		if (Bcount == 0)
			player.GetComponent <CircleCollider2D>().enabled = true;
	}
}
