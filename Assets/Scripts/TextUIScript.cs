using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIScript : MonoBehaviour {

	private Text tText;
	
	void Start(){
		tText = GetComponent<Text>();
		tText.text = "Cherchez et détruisez!!";
	}

	// Update is called once per frame
	void Update () {

		if (!GameObject.FindGameObjectWithTag("Cible"))
		{
			tText.text = "La porte est ouverte!!";
		}

		if (!GameObject.FindGameObjectWithTag("Skeleton"))
		{
			tText.text = "Allez défier le boss!!";
		}

		if (!GameObject.FindGameObjectWithTag("Boss"))
		{
			tText.text = "Bravo vous avez réussi ce donjon!!";
		}
	}

}
