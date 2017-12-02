using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShootScript : MonoBehaviour {

	public GameObject PrefabBullet;
	public Transform Canon;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
			Bullet.transform.position = Canon.position;
			Bullet.GetComponent<Rigidbody>().AddForce (Canon.forward * 200);
		}	
	}
}
