using UnityEngine;
using System.Collections;

public static class InputMobileManager
{
	public static bool GetTouchDown(int _id = 0)
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return Input.GetMouseButtonDown(0);
		#else
		return Input.GetTouch(_id).phase == TouchPhase.Began;
		#endif
	}
	
	public static bool GetTouchUp(int _id = 0)
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return Input.GetMouseButtonUp(0);
		#else
		return Input.GetTouch(_id).phase == TouchPhase.Ended;
		#endif
	}

	public static bool GetTouch(int _id=0)
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
			return Input.GetMouseButton (0);
		#else
		return Input.GetTouch(_id).phase == TouchPhase.Moved 
			|| Input.GetTouch(_id).phase == TouchPhase.Stationary;
		#endif
	}
	
	public static bool IsTouching()
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return true;
		#else
		return Input.touchCount > 0;
		#endif
	}
	
	public static int GetTouchNumber()
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return 1;
		#else
		return Input.touchCount;
		#endif
	}
	
	public static Vector2 GetPosition(int _id=0)
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return Input.mousePosition;
		#else
		return Input.GetTouch(_id).position;
		#endif
	}
	
	public static bool GetBackButton()
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		return Input.GetKeyDown(KeyCode.Backspace);
		#else
		return Input.GetKeyUp(KeyCode.Escape); //regresar en ANDROID,, IPHONE no tiene u.u
		#endif
	}
	
	public static RaycastHit2D Raycast2D(Camera _cam, int _layer = Physics2D.DefaultRaycastLayers, float _distance = 0f, int _id=0)
	{
		Ray ray = _cam.ScreenPointToRay(InputMobileManager.GetPosition(_id));
		return Physics2D.Raycast(ray.origin, ray.direction, _distance, _layer);
	}
}
