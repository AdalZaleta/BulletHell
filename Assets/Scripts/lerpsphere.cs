using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpsphere : MonoBehaviour {

	public AnimationCurve animcurv;

	// Use this for initialization
	void Start () {
		LeanTween.move (gameObject, new Vector3 (10f, 0f, 0f), 5f).setEase(animcurv);
		LeanTween.rotate (gameObject, new Vector3 (180f, 90f, 0f), 3f);
		LeanTween.scale (gameObject, new Vector3 (2f, 2f, 2f), 3f).setLoopPingPong();
		LeanTween.color (gameObject, Color.blue, 3f);
		LeanTween.color (gameObject, Color.red, 3f).setDelay (3f).setOnComplete(ChangetoGreen);

		LeanTween.value (gameObject, LerpCollider, 0.5f, 3f, 3f).setLoopPingPong();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangetoGreen()
	{
		LeanTween.color (gameObject, Color.green, 3f).setLoopPingPong();
	}

	void LerpCollider(float _val)
	{
		GetComponent<CapsuleCollider> ().radius = _val;
	}
}
