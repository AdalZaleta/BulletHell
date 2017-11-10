using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaivor : MonoBehaviour {

	public GameObject EyeCannonR, EyeCannonL, HandCannonR, HandCannonL, rightNip, leftNip;
	public float TotalHP;
	public float StartingHP;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < GetComponentsInChildren<BossParts> ().Length; i++) {
			StartingHP += GetComponentsInChildren<BossParts> () [i].HP;
		}
	}
	
	// Update is called once per frame
	void Update () {
		TotalHP = 0;
		for (int i = 0; i < GetComponentsInChildren<BossParts> ().Length; i++) {
			TotalHP += GetComponentsInChildren<BossParts> () [i].HP;
		}
		if (TotalHP > 0.8 * StartingHP) {
			EyeCannonL.GetComponent<Shoot> ().delay = 10;
			EyeCannonR.GetComponent<Shoot> ().delay = 10;
			HandCannonL.GetComponent<Shoot> ().delay = 10;
			HandCannonR.GetComponent<Shoot> ().delay = 10;
			rightNip.GetComponent<Shoot> ().delay = 10;
			leftNip.GetComponent<Shoot> ().delay = 10;
		}
		else if(TotalHP > 0.6 * StartingHP)
		{
			EyeCannonL.GetComponent<Shoot> ().delay = 5;
			EyeCannonR.GetComponent<Shoot> ().delay = 5;
			HandCannonL.GetComponent<Shoot> ().delay = 5;
			HandCannonR.GetComponent<Shoot> ().delay = 5;
			rightNip.GetComponent<Shoot> ().delay = 10;
			leftNip.GetComponent<Shoot> ().delay = 10;
		}
		else if(TotalHP > 0.4 * StartingHP)
		{
			EyeCannonL.GetComponent<Shoot> ().delay = 2;
			EyeCannonR.GetComponent<Shoot> ().delay = 2;
			HandCannonL.GetComponent<Shoot> ().delay = 2;
			HandCannonR.GetComponent<Shoot> ().delay = 2;
			rightNip.GetComponent<Shoot> ().delay = 10;
			leftNip.GetComponent<Shoot> ().delay = 10;
		}
		else if(TotalHP > 0.2 * StartingHP)
		{
			EyeCannonL.GetComponent<Shoot> ().delay = 1;
			EyeCannonR.GetComponent<Shoot> ().delay = 1;
			HandCannonL.GetComponent<Shoot> ().delay = 1;
			HandCannonR.GetComponent<Shoot> ().delay = 1;
			rightNip.GetComponent<Shoot> ().delay = 10;
			leftNip.GetComponent<Shoot> ().delay = 10;
		}
		if (HandCannonR.GetComponentInParent<BossParts> ().HP <= 0) {
			rightNip.GetComponent<Shoot> ().shootstyle = 2;
			HandCannonR.GetComponent<Shoot> ().shootstyle = 0;
		}
		if (HandCannonL.GetComponentInParent<BossParts> ().HP <= 0) {
			leftNip.GetComponent<Shoot> ().shootstyle = 2;
			HandCannonL.GetComponent<Shoot> ().shootstyle = 0;
		}
	}
}
