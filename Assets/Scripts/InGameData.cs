using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameData : MonoBehaviour {

	public GameObject player;
	public int atkid;
	public float BossHP;
	public Text lifeNo;
	public Image atktype;
	public Slider bossbar;
	public Sprite[] spritebois;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent <movementtest>().HP == 0)
			SceneManager.LoadScene ("GameOver");

		lifeNo.text = player.GetComponent<movementtest> ().HP.ToString ();
		if (atkid > 3)
			atkid = 3;
		atktype.sprite = spritebois [atkid];
		bossbar.value = BossHP;
	}
}
