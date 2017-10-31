using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {
	public static int Vida;
	public bool Rayo;
	public bool Explosion = false;
	public bool Escopeta = false;
	public bool quadShot = false;

	// Use this for initialization
	void Start () {
		Vida = 1;
		gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
	}
	
	void OnCollisionEnter(Collision _col)
	{
		//Checa si el escudo está activo
		if(gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled)
		{
			//Checa si choca con alguna bala ENEMIGA
			if(_col.gameObject.CompareTag ("EBullet"))
			{
				Destroy(gameObject);
			}
		}

		if (_col.gameObject.CompareTag ("PowerUp_Escudo")) {
			gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = true;
		}
		if (_col.gameObject.CompareTag ("PowerUp_Rayo")) {
			Rayo = true;
		}
		if (_col.gameObject.CompareTag ("PowerUp_Explosion")) {
			Explosion = true;
		}
		if (_col.gameObject.CompareTag ("PowerUp_Escopeta")) {
			Escopeta = true;
		}
		if (_col.gameObject.CompareTag ("PowerUp_quadShot")) {
			quadShot = true;
		}
	}
}
