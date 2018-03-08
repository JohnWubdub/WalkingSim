using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour 
{

	public Image whiteOut;
	
	
	// Use this for initialization
	void Start () 
	{
		whiteOut.GetComponent<CanvasRenderer>().SetAlpha(0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Global.me.stepsLeft == 0)
		{
			whiteOut.GetComponent<Image>().CrossFadeAlpha(1f, 1.0f, false);
		}
	}
}
