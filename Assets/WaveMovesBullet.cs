using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovesBullet : MonoBehaviour {

	public GameObject head, tail1, tail2;
	public float Amplitud, Frequencia, Velocidad;
	//K es el valor en el que va a empezar la funcion sen(k)
	public float K = 0;	
	float offset1, offset2;


	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2(0, Velocidad));
		offset1 = tail1.transform.position.y - head.transform.position.y;
		offset2 = tail2.transform.position.y - head.transform.position.y;

	}

	public void SetParameters(float A, float F, float Ka){
		Amplitud = A;
		Frequencia = F;
		K = Ka;
	}

	// Update is called once per frame
	void Update () {
		K += Frequencia;
		if (K >= 360) {
			K -= 360;
		}
			
		head.transform.position = new Vector3 (Mathf.Sin (K * Mathf.PI / 180) * Amplitud, gameObject.transform.position.y, 0);
		tail1.transform.position = new Vector3 (Mathf.Sin ((K-60) * Mathf.PI / 180) * Amplitud, gameObject.transform.position.y+offset1, 0);
		tail2.transform.position = new Vector3 (Mathf.Sin ((K - 120) * Mathf.PI / 180) * Amplitud,gameObject.transform.position.y +offset2, 0);



	}
}
