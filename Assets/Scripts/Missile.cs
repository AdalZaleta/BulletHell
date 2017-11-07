using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	public AnimationCurve curva;
	public float Escala, aceleracion;
	float t;

	// Update is called once per frame
	void Update () {
		t += aceleracion * Time.deltaTime;
		gameObject.GetComponent<Rigidbody2D>().velocity += Vector2.up * curva.Evaluate(t) * Escala * Time.deltaTime;
	}
}
