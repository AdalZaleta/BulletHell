using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour {

	public LayerMask mask;
	public Camera cam;
	bool setPivot = false;
	float offsetX;
	float offsetY;

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
			if (!setPivot)
			{
				offsetX = transform.position.x - Touchpos.x;
				offsetY = transform.position.y - Touchpos.y;
				setPivot = true;
			}
			Vector3 TruePos = new Vector3(Touchpos.x + offsetX, Touchpos.y + offsetY, 0.0f);

			transform.position = TruePos;
		}
		else
		{
			setPivot = false;
		}
	}

	void MovePlayer()
	{
		
	}
}
