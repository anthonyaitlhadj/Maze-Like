using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscensorScript : MonoBehaviour {

	public float Speed;	
	public Vector3 StartPosition;
	public Vector3 EndPosition;

	void Update ()
	{
		float f = Speed * Time.deltaTime;
		//transform.localPosition += new Vector3 (0, f, 0);
		transform.localPosition = Vector3.Lerp (StartPosition, EndPosition, Mathf.Sin(Time.time)+1)/2;
	}
}
