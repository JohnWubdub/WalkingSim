using UnityEngine;
using System.Collections;

public class Global : MonoBehaviourSingleton<Global> //acts almost like a bank for the global variables to be called later
{
	public static Global me;
	public float timeLeft = 60f; //seconds until collapse
	public int stepsLeft = 5;
	public bool passedOut = false;


	private void Awake()
	{
		me = this; //awakens the script
	}
}
