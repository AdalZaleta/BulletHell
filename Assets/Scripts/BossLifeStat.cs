using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLifeStat : MonoBehaviour {
	private int BLife = 30;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (BLife == 0) {
			Destroy (this.gameObject);
		}
	}


	void OnCollisionEnter2D(Collision2D _col)
	{
		if (_col.gameObject.CompareTag ("Bullet")) {
			BLife--;
		}
	}
}
