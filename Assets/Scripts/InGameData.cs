using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameData : MonoBehaviour {

	public int life;
	public int atkid;
	public float BossHP;
	public Text lifeNo;
	public Image atktype;
	public Slider bossbar;
	public Sprite[] spritebois;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lifeNo.text = life.ToString ();
		if (atkid > 3)
			atkid = 3;
		atktype.sprite = spritebois [atkid];
		bossbar.value = BossHP;
	}
}
