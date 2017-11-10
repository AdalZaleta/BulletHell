using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	// Use this for initialization
	void OnEnable () 
	{
		Invoke ("Eliminar", 2f);
	}

	void Eliminar()
	{
		gameObject.SetActive (false);
	}

	void OnDisable ()
	{
		gameObject.GetComponent <Rigidbody2D> ().velocity = Vector2.zero;
	}
}
