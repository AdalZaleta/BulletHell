using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

	public float HP;
	float lasercount;
	public Transform[] goTo;
	public Transform[] bezier;
	public float moveTime, stayTime, curveTime;
	public float startdelay;
	float deathtimer;
	public AudioSource AS;
	public AudioClip ReboteSFX;

	float framecount;

	void OnTriggerEnter2D (Collider2D _col)
	{
		lasercount = 0;
		if (_col.gameObject.CompareTag ("P_bullet"))
			HP--;
		AS.PlayOneShot (ReboteSFX);
	}

	void OnTriggerStay2D (Collider2D _col)
	{
		lasercount += 0.1f;
		if (_col.gameObject.CompareTag ("Laser"))
		{
			if (lasercount >= 0.2f)
			{	
				HP--;
			}
		}
		if (lasercount >= 0.2f)
			lasercount = 0;
	}

	// Use this for initialization
	void Start () {
		gameObject.GetComponent <BoxCollider2D>().enabled = false;
		StartCoroutine (activate(startdelay));
		deathtimer = startdelay + moveTime + stayTime + 1.0f;
		Destroy (gameObject, deathtimer);
		AS = GetComponent<AudioSource> ();
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
