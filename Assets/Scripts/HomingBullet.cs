using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBullet : MonoBehaviour {

	//Hay un prefab circular con este script, pero deberia de funcionar con cualquier forma que tenga un rigidbody2D

	public Transform target;
	public float Velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LookAt2D (gameObject.transform, target.position, 0);
		gameObject.GetComponent<Rigidbody2D> ().velocity = (target.position - gameObject.transform.position).normalized * Velocidad;
	}

	public void LookAt2D(Transform _transform, Vector3 _pos, float _offset)
	{
		Vector3 relative = _transform.InverseTransformPoint (_pos);
		float angle = Mathf.Atan2 (relative.x, relative.y) * Mathf.Rad2Deg - _offset;
		_transform.Rotate (0, 0, -angle, Space.Self);
	}


}
