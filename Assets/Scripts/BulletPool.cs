using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour {

	static int cnt = 0;
	static List<GameObject> bulletPool = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		cnt = 0;
		bulletPool = new List<GameObject> ();
		bulletPool.Add (gameObject);
	}

	void Clear ()
	{
		gameObject.SetActive (false);
	}

	void OnEnable()
	{
		cnt++;
		Invoke ("Clear", 3f);
	}

	public static GameObject generateBullet()
	{
		for (int i = 0; i < bulletPool.Count; i++)
		{
			if (bulletPool[i].activeSelf == false)
			{
				bulletPool[i].SetActive (true);
				return bulletPool[i];
			}
		}
		GameObject newBullet = Instantiate (bulletPool[0]) as GameObject;
		bulletPool.Add (newBullet);
		return newBullet;
	}

	void OnDisable()
	{
		cnt--;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
