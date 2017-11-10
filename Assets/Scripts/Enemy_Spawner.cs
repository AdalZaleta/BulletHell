using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

	public GameObject[] enemies;
	public Transform[] pivot;
	public float[] spawntimes;
	public float framecount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < spawntimes.Length; i++)
		{
			if (framecount >= spawntimes[i] && framecount < spawntimes[i]+0.1f)
			{
				if (enemies[i])
					Instantiate (enemies[i], pivot[i].position, pivot[i].rotation);
			}
		}

		framecount += 0.1f;
	}
}
