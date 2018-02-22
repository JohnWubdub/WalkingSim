using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour 
{

	
	//tempoaray code 
	public Text passoutText;
	public string regular = " ";
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Global.me.stepsLeft == 0)
		{
			passoutText.text = "You did it";
		}
	}
}
