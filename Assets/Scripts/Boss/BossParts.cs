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
	void OnTriggerEnter(Collider _col)
	{
		if(_col.CompareTag("P_bullet"))
		{
			HP -= _col.GetComponent<AllBullets> ().Damage * Armor;
		}
	}

}
