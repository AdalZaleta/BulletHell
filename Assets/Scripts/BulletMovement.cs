using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float speed;
	public GameObject pivot;

	// Use this for initialization
	void Start () {
		gameObject.transform.position = pivot.transform.position;
		gameObject.transform.rotation = pivot.transform.rotation;
	}

	void OnEnable ()
	{
		gameObject.transform.rotation = pivot.transform.rotation;
		gameObject.GetComponent <Rigidbody2D>().AddRelativeForce (Vector2.up * speed);
	}

	void OnDisable()
	{
		if (pivot)
			gameObject.transform.position = pivot.transform.position;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
