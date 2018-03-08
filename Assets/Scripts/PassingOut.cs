using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassingOut : MonoBehaviour
{
	public Image passOut;

	void Start()
	{
		passOut.GetComponent<CanvasRenderer>().SetAlpha(0.1f);
	}

	void Update()
	{
		if (Global.me.timeLeft < 50f)
		{
			passOut.GetComponent<Image>().CrossFadeAlpha(.2f, .5f, false);
		}
		if (Global.me.timeLeft < 40f)
		{
			passOut.GetComponent<Image>().CrossFadeAlpha(.4f, .5f, false);
		}
		if (Global.me.timeLeft < 30f)
		{
			passOut.GetComponent<Image>().CrossFadeAlpha(.6f, .5f, false);
		}
		if (Global.me.timeLeft < 20f)
		{
			passOut.GetComponent<Image>().CrossFadeAlpha(.8f, .5f, false);
		}
		if (Global.me.timeLeft < 10f)
		{
			passOut.GetComponent<Image>().CrossFadeAlpha(1f, .5f, false);
		}
		if (Global.me.timeLeft < 0f) //game over
		{
			Global.me.timeLeft = 0f;
			Global.me.passedOut = true;
			passOut.GetComponent<Image>().CrossFadeAlpha(4f, 1f, false);
		}	
	}
	

}
