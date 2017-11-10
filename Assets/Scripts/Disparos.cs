using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour {

	public bool puedo = true;
	public float delay, veldis;
	public GameObject DisparoIzq, DisparoIzqx, DisparoDer, DisparoDerx ,DisparoCen;
	public GameObject[] bala;
	public GameObject rayol;
	public int Modo;
	List<GameObject> poolDisparo = new List<GameObject> ();

	public GameObject GenerarBala(Vector3 _pos)
	{
		for(int i = 0; i < poolDisparo.Count; i++)
		{
			if(poolDisparo [i].activeSelf == false)
			{
				//Si esta desactivadp, significa que puedo reciclarlo
				poolDisparo [i].transform.position = _pos;
				poolDisparo[i].SetActive (true);
				return poolDisparo [i];//Regreso el GameObject
			}
		}
		//Si llega a salir del for, significa que no hay cubos disponibles
		//Entonces genero uno nuevo
		GameObject nuevoDisparo = Instantiate (bala[0]) as GameObject;
		//Lo agreagamos al pool
		nuevoDisparo.transform.position = _pos;
		poolDisparo.Add (nuevoDisparo);
		return nuevoDisparo;
	}

	void OnEnable ()
	{
		puedo = true;
	}

	void Update ()
	{
		if (gameObject.GetComponent <PowerUps>().Escopeta == true)
			Modo = 1;
		if (gameObject.GetComponent <PowerUps>().quadShot == true)
			Modo = 2;
		if (gameObject.GetComponent <PowerUps>().Rayo == true)
			Modo = 3;

		if (Input.touchCount > 0 && puedo && Modo == 1)
		{
			GameObject go = GenerarBala (DisparoIzq.gameObject.transform.position);
			GameObject go1 = GenerarBala (DisparoDer.gameObject.transform.position);
			go.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			go1.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			puedo = false;
			StartCoroutine (Disparar ());
		}
		if (Input.touchCount > 0 && puedo && Modo == 2)
		{
			GameObject go = GenerarBala (DisparoIzq.gameObject.transform.position);
			GameObject go1 = GenerarBala (DisparoDer.gameObject.transform.position);
			GameObject go2 = GenerarBala (DisparoIzqx.gameObject.transform.position);
			GameObject go3 = GenerarBala (DisparoDerx.gameObject.transform.position);
			go.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			go1.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			go2.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			go3.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * veldis);
			puedo = false;
			StartCoroutine (Disparar ());
		}
		if (Input.touchCount > 0 && puedo && Modo == 3)
		{
			rayol.gameObject.GetComponent<Renderer> ().enabled = true;
			rayol.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		}
		if(Modo != 3)
		{
			rayol.gameObject.GetComponent<Renderer> ().enabled = false;
			rayol.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}

	IEnumerator Disparar()
	{
		yield return new WaitForSeconds (delay);
		puedo = true;
	}
}