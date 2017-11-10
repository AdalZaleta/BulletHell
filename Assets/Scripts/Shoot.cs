using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public int shootstyle;
	public float delay;
	float shootdelay;
	float framecount = 0;
	float framecountS = 0;
	public GameObject pivot;
	GameObject player;
	bool tilt = false;
	public bool Trigger_Circle;
	public bool Trigger_Spiral;

	bool onscreen;
	float Xmin;
	float Xmax;
	float Ymin;
	float Ymax;

	// Use this for initialization
	void Start () {
		Vector2 corner = Camera.main.ScreenToWorldPoint (Vector3.zero);

		Xmin = corner.x;
		Xmax = -corner.x;
		Ymin = corner.y;
		Ymax = -corner.y;

		player = GameObject.FindGameObjectWithTag ("Player");
		shootdelay = delay;
	}
	
	// Update is called once per frame
	void Update ()
	{
		shootdelay -= 0.2f;
		framecountS += 0.2f;
		framecount += 0.2f;

		if (transform.position.x >= Xmin && transform.position.x <= Xmax && transform.position.y >= Ymin && transform.position.y <= Ymax)
			onscreen = true;
		else
			onscreen = false;

		if (shootstyle == 1 && onscreen) {
			Shoot_Spiral ();
		}

		if (shootstyle == 2 && onscreen) {
			Shoot_Circle ();
		}

		if (shootstyle == 3 && shootdelay <= 0 && onscreen) {
			Shoot_Heatseak ();
		}

		if (Trigger_Spiral) {
			if (framecountS >= 0.8) {
				pivot.transform.Rotate (Vector3.forward * 10);
				for (int i = 0; i < 4; i++) {
					pivot.transform.Rotate (0.0f, 0.0f, 90.0f * i);
					BulletPool.generateBullet ();
				}
			}
		}

		if (Trigger_Circle) {
			if (framecount >= 1.5) {
				if (tilt) {
					pivot.transform.Rotate (0.0f, 0.0f, 0.0f);
					tilt = false;
				}
				else if (!tilt) {
					pivot.transform.Rotate (0.0f, 0.0f, 10.0f);
					tilt = true;
				}
				for (int i = 0; i < 16; i++) {
					pivot.transform.Rotate (0.0f, 0.0f, (360.0f / 16.0f) * i);
					BulletPool.generateBullet ();
				}
			}
		}

		if (shootdelay <= 0)
			shootdelay = delay;
		if (framecountS >= 0.8)
			framecountS = 0;
		if (framecount >= 1.5)
			framecount = 0;
	}



	public void Shoot_Spiral ()
	{
		Trigger_Spiral = !Trigger_Spiral;
	}

	public void Shoot_Circle ()
	{
		Trigger_Circle = !Trigger_Circle;
	}

	public void Shoot_Heatseak ()
	{
		if (player)
		{
			LookAt2D (pivot.transform, player.transform.position, 0);
			StartCoroutine (Burst ());
		}
	}

	void LookAt2D(Transform _transform, Vector3 _pos, float _offset)
	{
		Vector3 relative = _transform.InverseTransformPoint (_pos);
		float angle = Mathf.Atan2 (relative.x, relative.y) * Mathf.Rad2Deg - _offset;
		_transform.Rotate (0, 0, -angle, Space.Self);
	}

	IEnumerator Burst()
	{
		BulletPool.generateBullet ();
		yield return new WaitForSeconds (0.1f);
		BulletPool.generateBullet ();
		yield return new WaitForSeconds (0.1f);
		BulletPool.generateBullet ();
	}

}
