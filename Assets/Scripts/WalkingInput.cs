using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class WalkingInput : MonoBehaviour //keycode based input. Random key generator
{
	//temporary code!
	public Text stepText;
	public String regular = " ";

	//keycodes for the walking input
	//All of them are in order
	public bool rightActive = true;
	public bool leftActive = false;
	
	public KeyCode right1 = KeyCode.X;
	public KeyCode right2 = KeyCode.R;
	public KeyCode right3 = KeyCode.P;
	public KeyCode right4 = KeyCode.A;
	public KeyCode right5 = KeyCode.M;
	
	public bool boolRight1 = false;
	public bool boolRight2 = false;
	public bool boolRight3 = false;
	public bool boolRight4 = false;
	public bool boolRight5 = false;

	public KeyCode left1 = KeyCode.N;
	public KeyCode left2 = KeyCode.F;
	public KeyCode left3 = KeyCode.E;
	public KeyCode left4 = KeyCode.J;
	public KeyCode left5 = KeyCode.F;

	public bool boolLeft1 = false;
	public bool boolLeft2 = false;
	public bool boolLeft3 = false;
	public bool boolLeft4 = false;
	public bool boolLeft5 = false;

	public GameObject rightFoot;
	public GameObject leftFoot;

	public float minusTime = .5f;

	public Vector3 startingPoint1 = new Vector3();
	
	void Start () 
	{
		
	}
	
	void Update ()
	{
		
	}

	void FixedUpdate()
	{
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 5)
		{
			//rightMovement();
		}
		
		if (leftActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 4)
		{
			leftMovement();
		}
		
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 3)
		{
			//rightMovement();
		}
		
		if (leftActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 2)
		{
			leftMovement();
		}
		
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 1)
		{
			//rightMovement();
		}	
	}

	public void rightMovement(Vector3 startPos, Vector3 endPos)
	{
		//first input
		if (Input.GetKey(right1) && Global.me.passedOut == false)
		{
			Timer.addTime();
			Debug.Log("1");
			boolRight1 = true;
		}
		else
		{
			boolRight1 = false;
		}
		
		//second input
		if (Input.GetKey(right2) && boolRight1 == true && Global.me.passedOut == false)
		{
			Debug.Log("2");
			boolRight2 = true;
		}
		else
		{
			boolRight2 = false;
		}
		
		//third input
		if (Input.GetKey(right3) && boolRight2 == true  && Global.me.passedOut == false)
		{
			Debug.Log("3");
			boolRight3 = true;
		}
		else
		{
			boolRight3 = false;
		}
		
		//fourth input
		if (Input.GetKey(KeyCode.A) && boolRight3 == true && Global.me.passedOut == false)
		{
			Debug.Log("4");
			boolRight4 = true;
		}
		else
		{
			boolRight4 = false;
		}
		
		//fifth input
		if (Input.GetKey(right5) && boolRight4 == true && Global.me.passedOut == false)
		{
			Debug.Log("5");
			boolRight5 = true;
		}
		else
		{
			boolRight5 = false;
		}
		
		//end of the step
		if (boolRight5 == true)
		{
			stepText.text = "You said the fuck word and took a step foward!";
			boolRight1 = false;
			boolRight2 = false;
			boolRight3 = false;
			boolRight4 = false;
			boolRight5 = false;
			Global.me.stepsLeft -= 1;
			leftActive = true;
			rightActive = false;
		}
	}


	public void leftMovement()
	{
		//first input
		if (Input.GetKey(left1) && Global.me.passedOut == false)
		{
			stepText.text = "";
			Timer.addTime();
			Debug.Log("1");
			boolLeft1 = true;
		}
		else
		{
			boolLeft1 = false;
		}
		
		//second input
		if (Input.GetKey(left2) && boolLeft1 == true && Global.me.passedOut == false)
		{
			Debug.Log("2");
			boolLeft2 = true;
		}
		else
		{
			boolLeft2 = false;
		}
		
		//third input
		if (Input.GetKey(left3) && boolLeft2 == true  && Global.me.passedOut == false)
		{
			Debug.Log("3");
			boolLeft3 = true;
		}
		else
		{
			boolLeft3 = false;
		}
		
		//fourth input
		if (Input.GetKey(left4) && boolLeft3 == true && Global.me.passedOut == false)
		{
			Debug.Log("4");
			boolLeft4 = true;
		}
		else
		{
			boolLeft4 = false;
		}
		
		//fifth input
		if (Input.GetKey(left5) && boolLeft4 == true && Global.me.passedOut == false)
		{
			Debug.Log("5");
			boolLeft5 = true;
		}
		else
		{
			boolLeft5 = false;
		}
		
		//end of the step
		if (boolRight5 == true)
		{
			stepText.text = "You said the fuck word and took a step foward!";
			boolLeft1 = false;
			boolLeft2 = false;
			boolLeft3 = false;
			boolLeft4 = false;
			boolLeft5 = false;
			Global.me.stepsLeft -= 1;
			rightActive = true;
			leftActive = false;
		}
			
	}

	public void stepFoward(Transform position, Vector3 startingPoint, float time, int toAdd)
	{
		
	}

	public void stepBackward(Transform position, Vector3 startingPoint, float time, int toMinus)
	{
		
	}
	
	

	
	
}
