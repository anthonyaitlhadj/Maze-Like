using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	void Start()
    {
		Destroy (gameObject, 2);
    }

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.GetComponent<LifeScript>()) 
		{
			c.gameObject.GetComponent<LifeScript>().Damage(5);
		}
		Destroy(gameObject);
	}
}
