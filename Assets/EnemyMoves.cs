using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour {

	public static void ComeAndGo(GameObject unit, Transform[] goal, float getThere, float stayThere)
	{
		Vector3 start = unit.transform.position;
		for (int i = 0; i < goal.Length; i++) {
			LeanTween.move (unit, goal[i].position, getThere).setDelay(getThere*i + stayThere*i);
		}
	}

	public static void Curve(GameObject unit, Transform[] bezier, float time)
	{
		LTBezierPath ItPath = new LTBezierPath (new Vector3[] {
			unit.transform.position,	//Transform donde inicia el objeto
			bezier[0].position,			//Transform que representa el controlador de curva del punto final
			bezier[1].position,			//Transform que representa el controlador de curva del punto inicial
			bezier[2].position			//Tranform donde termina el objeto
		});
		LeanTween.move (unit, ItPath, time).setOrientToPath (false).setEase (LeanTweenType.easeInQuad);
	}
}
