using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public float Speed;
	public bool IsOpen = false;
	public Vector3 StartPosition;
	public Vector3 EndPosition;

	void OnTriggerEnter(Collider c)
	{
		Destroy (gameObject,5);
		IsOpen = true;
	}

	void Update ()
	{
		if (IsOpen) {
			float f = Speed * Time.deltaTime;
			transform.localPosition += new Vector3 (0, f, 0);
		}
	}
}
