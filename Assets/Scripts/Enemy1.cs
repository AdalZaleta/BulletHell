using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

	public Transform[] goTo;
	public Transform[] bezier;
	public float moveTime, stayTime, curveTime;
	// Use this for initialization
	void Start () {
		
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.A)) {
			EnemyMoves.ComeAndGo (gameObject, goTo, moveTime, stayTime);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			EnemyMoves.Curve (gameObject, bezier, curveTime);
		}
	}

}
