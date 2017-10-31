using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour {

	public bool puedo = true;
	public float delay, veldis;
	public GameObject DisparoIzq, DisparoIzqx, DisparoDer, DisparoDerx ,DisparoCen;
	public GameObject bala;
	public int Modo;

	void Update ()
	{
		if (InputMobileManager.GetTouch () && puedo && Modo == 1)
		{
			GameObject go = Instantiate (bala, DisparoIzq.gameObject.transform.position, Quaternion.identity);
			GameObject go1 = Instantiate (bala, DisparoDer.gameObject.transform.position, Quaternion.identity);
			go.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			go1.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			puedo = false;
			StartCoroutine (Disparar ());
		}
	}

	IEnumerator Disparar()
	{
		yield return new WaitForSeconds (delay);
		puedo = true;
	}
}
