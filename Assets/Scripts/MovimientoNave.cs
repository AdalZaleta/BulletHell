using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour {
	Vector2 LastTouchPos;
	public float Velocidad = 0.1f;

	// Use this for initialization
	void Start () {
		LastTouchPos = InputMobileManager.GetPosition ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(InputMobileManager.GetTouch ())
		{
			print (InputMobileManager.GetPosition ());
			Vector2 Posfinal = InputMobileManager.GetPosition ();
			Vector2 deltaPos = LastTouchPos - Posfinal;
			transform.Translate (-deltaPos.x * Velocidad, -deltaPos.y * Velocidad, 0);

			LastTouchPos = Posfinal;
		}
	}
}
