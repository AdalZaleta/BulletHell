using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobTorax : MonoBehaviour {

	public GameObject torax;
	public GameObject jaw;
	public GameObject R_shoulder;
	public GameObject L_shoulder;
	public GameObject R_elbow;
	public GameObject L_elbow;

	// Use this for initialization
	void Start () {
		LeanTween.move (torax, torax.transform.position + new Vector3 (0.0f, 0.6f, 0.0f), 1.5f).setLoopPingPong ();
		LeanTween.move (jaw, jaw.transform.position - new Vector3 (0.0f, 0.3f, 0.0f), 0.3f).setLoopPingPong ();
		LeanTween.rotate (R_shoulder, new Vector3 (30f, 0.0f, 0.0f), 2f).setLoopPingPong ();
		LeanTween.rotate (L_shoulder, new Vector3 (-20f, 0.0f, 0.0f), 1.8f).setLoopPingPong ();
		LeanTween.rotate (R_elbow, new Vector3 (25f, 0.0f, 0.0f), 1.6f).setLoopPingPong ();
		LeanTween.rotate (L_elbow, new Vector3 (-15f, 0.0f, 0.0f), 1.5f).setLoopPingPong ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
