using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplosion : MonoBehaviour {

	public GameObject bullet;
	public int NofBullets;
	public float velocidad;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < NofBullets; i++) {
			GameObject go = Instantiate (bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.Euler(0, 0, 360.0f/NofBullets * i));
			Vector2 upself = transform.TransformDirection (Vector2.up);
			go.GetComponent<Rigidbody2D> ().AddRelativeForce (upself * velocidad);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
