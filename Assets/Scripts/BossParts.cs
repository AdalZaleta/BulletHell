using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossParts : MonoBehaviour {

	public float HP;
	public float Armor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D _col)
	{
		if (_col.CompareTag ("Bullet")) {
			
		}
	}
}
