using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLifeStat : MonoBehaviour {
	public int BLife = 30;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (BLife == 0) {
			Destroy (this.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D _col)
	{
		Debug.Log ("collision");
		if (_col.gameObject.CompareTag ("Bullet")) {
			Debug.Log ("collision");
			BLife--;
		}
	}
}
