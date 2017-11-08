using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	float framecount = 0;
	public GameObject pivot;
	GameObject player;
	bool tilt = false;
	public bool Trigger_Circle;
	public bool Trigger_Spiral;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		framecount += 0.2f;

		if (Input.GetKey (KeyCode.K)) {
			Shoot_Spiral ();
		}

		if (Input.GetKey (KeyCode.J)) {
			Shoot_Circle ();
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			Shoot_Heatseak ();
		}

		if (Trigger_Spiral) {
			if (framecount >= 1.5) {
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
