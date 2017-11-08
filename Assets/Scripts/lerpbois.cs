using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpbois : MonoBehaviour {

	Vector3 Target = new Vector3 (10f, 0f, 5f);
	Vector3 Origin;
	public float p = 0.0f;
	float timescale;

	// Use this for initialization
	void Start () {
		Origin = transform.position;
		timescale = 1f / 5f; // 5 sec Delay before arrival
	}
	
	// Update is called once per frame
	void Update () {

		// Wrong Method (Infinite Divisions)
		//transform.position = Vector3.Lerp (transform.position, Target, Time.deltaTime);

		// Correct Method
		p += Time.deltaTime * timescale;
		if (p >= 1.0f)
			p = 1.0f;
		transform.position = Vector3.Lerp(Origin, Target, p);
	}
}
