using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorSFX : MonoBehaviour {
	public AudioSource AS;
	public Disparos Disparos;
	public AudioClip Shot1;

	// Use this for initialization
	void Start () {
		Disparos = GameObject.FindObjectOfType<Disparos> ();
		AS = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
