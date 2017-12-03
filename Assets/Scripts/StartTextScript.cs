using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour {
	private Text beginText;
	
	void Start(){
		beginText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (!GameObject.FindGameObjectWithTag("Cible"))
		{
			beginText.text = "La porte est ouverte!!";
		}
	}
}
