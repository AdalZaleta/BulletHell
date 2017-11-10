using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBullets : MonoBehaviour {

	public GameObject debris;
	public float Damage;
	static List<GameObject> poolDebris = new List<GameObject> ();

	void OnCollisionEnter2D(Collision2D _col)
	{
		if (_col.gameObject.CompareTag (gameObject.tag) == false) {
			DeletThis ();
		}
	}
	void OnEnable () 
	{
		Invoke ("DeletThis", 1f);
	}
	public void DeletThis()
	{
		if (debris != null) {
			for (int i = 0; i < poolDebris.Count; i++) {
				if (poolDebris [i].activeSelf == false) {
					poolDebris [i].SetActive (true);
					poolDebris [i].transform.position = gameObject.transform.position;
					return;
				}
			}

			GameObject newDebris = Instantiate (debris, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
			poolDebris.Add (newDebris);
		}
		gameObject.SetActive (false);
	}

	void OnDisable ()
	{
		gameObject.GetComponent <Rigidbody2D> ().velocity = Vector2.zero;
	}
}
