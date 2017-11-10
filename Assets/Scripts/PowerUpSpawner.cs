using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour {

	public GameObject[] PowerUps;
	public Transform[] spawner;
	List<GameObject> prefabList = new List<GameObject> ();
	public float[] spawntimes;
	public float framecount;
	int prefabIndex;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < spawntimes.Length; i++)
		{
			if (framecount >= spawntimes[i] && framecount < spawntimes[i]+0.1f)
			{
				Instantiate (PowerUps[i], spawner[i].position, spawner[i].rotation);
				prefabIndex = UnityEngine.Random.Range (0, prefabList.Count-1);
			}
		}

		framecount += 0.1f;
	}
}
