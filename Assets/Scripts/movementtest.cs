using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour {

	public LayerMask mask;
	public Camera cam;

	RaycastHit2D hit;
	Vector2 Touchpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0)
		{
			Touchpos = cam.ScreenToWorldPoint (Input.GetTouch (0).position);
			transform.position = Touchpos;
		}
	}

	void MovePlayer()
	{
		
	}
}
