using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}

	void OnEnable()
	{
		anim.Play ("Exprosion", 0, 0f);
	}

	// Update is called once per frame
	void Update () {
		if(anim.GetCurrentAnimatorStateInfo (0).IsName("Exprosion") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99f)
		{
			gameObject.SetActive(false);
		}
	}
}
