using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour {

	public int Pv; 

	void Start()
	{
		Debug.Log(Pv);
	}

	public virtual void Damage(int d)
	{
		Pv -= d;
	}
}
