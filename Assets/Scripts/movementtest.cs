using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour {

	public LayerMask mask;
	public Camera cam;
	bool setPivot = false;
	float offsetX;
	float offsetY;

	public float Xmin;
	public float Xmax;
	public float Ymin;
	public float Ymax;

	public int HP = 3;

	RaycastHit2D hit;
	Vector2 Touchpos;

	void OnTriggerEnter2D (Collider2D _col)
	{
		if (_col.gameObject.CompareTag ("Bullet"))
		{
			HP--;
			gameObject.GetComponent <CircleCollider2D>().enabled = false;
			gameObject.SetActive (false);
		}
	}

	// Use this for initialization
	void Start () {
		Vector2 corner = Camera.main.ScreenToWorldPoint (Vector3.zero);

		Xmin = corner.x;
		Xmax = -corner.x;
		Ymin = corner.y;
		Ymax = -corner.y;
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
			if (transform.position.x <= Xmin)
				transform.position = new Vector3(Xmin, transform.position.y, 0.0f);
			if (transform.position.x >= Xmax)
				transform.position = new Vector3(Xmax, transform.position.y, 0.0f);
			if (transform.position.y <= Ymin)
				transform.position = new Vector3(transform.position.x, Ymin, 0.0f);
			if (transform.position.y >= Ymax)
				transform.position = new Vector3(transform.position.x, Ymax, 0.0f);
		}
		else
		{
			setPivot = false;
		}
	}
}
