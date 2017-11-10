using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour {

	public GameObject PU_D;
	public GameObject PU_L;
	public GameObject PU_S;
	public GameObject PU_Q;
	public GameObject[] PowerUps;
	public Transform[] spawner;
	List<GameObject> prefabList = new List<GameObject> ();
	public float[] spawntimes;
	public float framecount;
	int prefabIndex;


	// Use this for initialization
	void Start () {
		prefabList.Add (PU_D);
		prefabList.Add (PU_L);
		prefabList.Add (PU_S);
		prefabList.Add (PU_Q);
		prefabIndex = UnityEngine.Random.Range (0, prefabList.Count-1);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < spawntimes.Length; i++)
		{
			if (framecount >= spawntimes[i] && framecount < spawntimes[i]+0.1f)
			{
				Instantiate (prefabList[prefabIndex], spawner[i].position, spawner[i].rotation);
				prefabIndex = UnityEngine.Random.Range (0, prefabList.Count-1);
			}
		}

		framecount += 0.1f;
	}
}
