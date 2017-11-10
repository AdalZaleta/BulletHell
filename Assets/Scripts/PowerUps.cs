using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {
	public int Vida;
	public int EscudoLife;
	public bool Rayo;
	public bool Explosion = false;
	public bool Escopeta = false;
	public bool quadShot = false;

	void Start () {
		Vida = 3;
		EscudoLife = 10;
		gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
	}
	void Update()
	{
		if(Vida == 0)
		{
			Destroy (this.gameObject);
		}
		if (EscudoLife == 0) {
			gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
			EscudoLife = 10;
		}
	}
	
	void OnTriggerEnter2D(Collider2D _col)
	{
		//Checa si el escudo está activo
		if (gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled) {
			//Checa si choca con alguna bala ENEMIGA
			if (_col.gameObject.CompareTag ("EBullet")) {
				Destroy (_col.gameObject);
			}
		} else {
			if (_col.gameObject.CompareTag ("EBullet")) {
				Vida--;
				Destroy (_col.gameObject);
			}
		}

		if (_col.gameObject.CompareTag ("PowerUp_Escudo")) {
			gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = true;
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
