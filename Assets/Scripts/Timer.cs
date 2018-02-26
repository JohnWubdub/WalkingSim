using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Timer : MonoBehaviour 
{
	
	void Start () 
	{
		
	}
	

	void Update () 
	{
		subTime();
	}
	
	public static void addTime()
	{
		float toAdd;
		if (Global.me.timeLeft < 60)
		{
			toAdd =  60f - Global.me.timeLeft;
			Debug.Log(toAdd);
			Global.me.timeLeft += toAdd;
		}
	}

	public void subTime()
	{
		Global.me.timeLeft -= Time.deltaTime;
	}
}
