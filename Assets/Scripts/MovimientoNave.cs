using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour {

	public float Velocidad = 0.1f;
	Vector2 LastTouchPos;

	// Use this for initialization
	void Start () 
	{
		LastTouchPos = InputMobileManager.GetPosition ();
		Vector2 LimiteSuperiorIzq = Camera.main.ScreenToWorldPoint (Vector3.zero);
		print (LimiteSuperiorIzq);
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
