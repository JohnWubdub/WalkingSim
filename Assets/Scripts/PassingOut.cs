using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassingOut : MonoBehaviour
{
	//tempoaray code 
	public Text passoutText;
	public string regular = " ";
	
	//slowy increasing the black fade on the screen

	void Update()
	{
		//other scripts that increse the opacity as they start to passout

		float newTime = Global.me.timeLeft;
		Debug.Log("anything");
		if (Global.me.timeLeft < 0f) //game over
		{
			Global.me.timeLeft = 0f;
			passoutText.text = "You fucking passed out bro";
			Debug.Log("passedout");
			Global.me.passedOut = true;
		}	
	}
	

}
