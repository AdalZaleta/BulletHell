using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public int EscudoLife;
	public bool Rayo;
	public bool Explosion = false;
	public bool Escopeta = false;
	public bool quadShot = false;

	void Start () {
		EscudoLife = 10;
		gameObject.transform.GetChild (0).GetComponent <MeshRenderer> ().enabled = false;
		gameObject.transform.GetChild (0).GetComponent <CircleCollider2D> ().enabled = false;
	}

	void Update()
	{
		if (EscudoLife == 0) {
			gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
			gameObject.transform.GetChild (0).GetComponent <CircleCollider2D> ().enabled = false;
			EscudoLife = 10;
		}
	}
	
	void OnTriggerEnter2D(Collider2D _col)
	{
		//Checa si el escudo está activo
		if (gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled) {
			//Checa si choca con alguna bala ENEMIGA
			if (_col.gameObject.CompareTag ("Bullet")) {
				Destroy (_col.gameObject);
			}
		}

		if (_col.gameObject.CompareTag ("PowerUp_Escudo")) {
			gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = true;
			gameObject.transform.GetChild (0).GetComponent <CircleCollider2D> ().enabled = true;
			Destroy (_col.gameObject);
		}
		if (_col.gameObject.CompareTag ("PowerUp_Rayo")) {
			Rayo = true;
			Destroy (_col.gameObject);
		}
		if (_col.gameObject.CompareTag ("PowerUp_Explosion")) {
			Explosion = true;
			Destroy (_col.gameObject);
		}
		if (_col.gameObject.CompareTag ("PowerUp_Escopeta")) {
			Escopeta = true;
			Destroy (_col.gameObject);
		}
		if (_col.gameObject.CompareTag ("PowerUp_quadShot")) {
			quadShot = true;
			Destroy (_col.gameObject);
		}
	}
}