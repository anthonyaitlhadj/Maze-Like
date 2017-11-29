using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2);
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.GetComponent<LifeScript>()) 
		{
			c.gameObject.GetComponent<LifeScript>().Damage(2);
		}
		Destroy(gameObject);
	}
}
