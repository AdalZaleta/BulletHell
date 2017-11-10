using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void OnEnable () 
	{
		Invoke ("Eliminar", 1f);
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
