using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieLifeStat : MonoBehaviour {
	private int ELife = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ELife == 0) {
			Destroy (this.gameObject);
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D _col)
	{
		if (_col.gameObject.CompareTag ("Bullet")) {
			ELife--;
			Destroy (_col.gameObject);
		}
	}
}
