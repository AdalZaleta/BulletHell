﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBullets : MonoBehaviour {

	public GameObject debris;

	void OnCollisionEnter2D(Collision2D _col)
	{
		if (_col.gameObject.CompareTag ("Wall")) {
			DeletThis ();
		}
	}

	public void DeletThis()
	{
		if (debris != null) {
			Instantiate (debris, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
		}
		gameObject.SetActive (false);
	}
}