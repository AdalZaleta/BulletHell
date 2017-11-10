using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

	public float HP;
	public Transform[] goTo;
	public Transform[] bezier;
	public float moveTime, stayTime, curveTime;
	public float startdelay;
	float deathtimer;

	float framecount;

	void OnTriggerEnter2D (Collider2D _col)
	{
		if (_col.gameObject.CompareTag ("P_bullet"))
			HP--;
	}

	// Use this for initialization
	void Start () {
		gameObject.GetComponent <BoxCollider2D>().enabled = false;
		StartCoroutine (activate(startdelay));
		deathtimer = startdelay + moveTime + stayTime + 1.0f;
		Destroy (gameObject, deathtimer);
		if (goTo.Length != 0)
			StartCoroutine (Goto ());
		if (bezier.Length != 0)
			StartCoroutine (Bezi ());
	}
	void Update(){
		if(HP == 0)
			Destroy (gameObject);
	}

	IEnumerator Goto ()
	{
		yield return new WaitForSeconds (startdelay);
		EnemyMoves.ComeAndGo (gameObject, goTo, moveTime, stayTime);
	}

	IEnumerator Bezi ()
	{
		yield return new WaitForSeconds (startdelay);
		EnemyMoves.Curve (gameObject, bezier, curveTime);
	} 

	IEnumerator activate (float _delay)
	{
		yield return new WaitForSeconds (_delay);
		gameObject.GetComponent <BoxCollider2D>().enabled = true;
	}
}
