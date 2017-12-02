using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrelLifeScript : LifeScript {

	public Text CountBarrelText;

    private int countBarrel;

    void Start ()
    {
        countBarrel = 0;
        SetCountText();
    }

	public override void Damage(int d)
	{
		base.Damage(d);
		if (Pv <= 0)
			countBarrel += 1;
			SetCountText();
			Destroy (gameObject);
	}

	void SetCountText()
    {
        CountBarrelText.text = "Count barrel : " + (int)countBarrel+"";
    }
}
