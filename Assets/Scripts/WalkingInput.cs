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
	public KeyCode right4 = KeyCode.A; //G keycode wasn't working
	public KeyCode right5 = KeyCode.M;
	
	public bool boolRight1 = false;
	public bool boolRight2 = false;
	public bool boolRight3 = false;
	public bool boolRight4 = false;
	public bool boolRight5 = false;

	public KeyCode left1 = KeyCode.N;
	public KeyCode left2 = KeyCode.F;
	public KeyCode left3 = KeyCode.E;
	public KeyCode left4 = KeyCode.Q; //J keycode wasn't working for some reason 
	public KeyCode left5 = KeyCode.W; //H keycode now

	public bool boolLeft1 = false;
	public bool boolLeft2 = false;
	public bool boolLeft3 = false;
	public bool boolLeft4 = false;
	public bool boolLeft5 = false;


	void FixedUpdate()
	{
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 5) //right
		{
			rightMovement();
		}
		
		if (leftActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 4) //left
		{
			leftMovement();
		}
		
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 3) //right
		{
			rightMovement();
		}
		
		if (leftActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 2) //left
		{
			leftMovement();
		}
		
		if (rightActive == true && Global.me.timeLeft > 0 && Global.me.stepsLeft == 1) //right
		{
			rightMovement();
		}	
	}

	public void rightMovement() //Vector3 startPos, Vector3 endPos
	{
		//counter for the tiny steps
		int tinyStepCount = 0;

		//first input
		if (Input.GetKey(right1) && Global.me.passedOut == false)
		{
			Timer.addTime();
			Debug.Log("1");
			boolRight1 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepRightFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolRight1 = false;
			GetComponent<MovingFeet>().tinyStepRightBac(tinyStepCount); //moving the foot
		}
		
		//second input
		if (Input.GetKey(right2) && boolRight1 == true && Global.me.passedOut == false)
		{
			Debug.Log("2");
			boolRight2 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepRightFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolRight2 = false;
			GetComponent<MovingFeet>().tinyStepRightBac(tinyStepCount); //moving the foot
		}
		
		//third input
		if (Input.GetKey(right3) && boolRight2 == true  && Global.me.passedOut == false)
		{
			Debug.Log("3");
			boolRight3 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepRightFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolRight3 = false;
			GetComponent<MovingFeet>().tinyStepRightBac(tinyStepCount); //moving the foot
		}
		
		//fourth input
		if (Input.GetKey(KeyCode.A) && boolRight3 == true && Global.me.passedOut == false)
		{
			Debug.Log("4");
			boolRight4 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepRightFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolRight4 = false;
			GetComponent<MovingFeet>().tinyStepRightBac(tinyStepCount); //moving the foot
		}
		
		//fifth input
		if (Input.GetKey(right5) && boolRight4 == true && Global.me.passedOut == false)
		{
			Debug.Log("5");
			boolRight5 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepRightFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolRight5 = false;
			GetComponent<MovingFeet>().tinyStepRightBac(tinyStepCount); //moving the foot
		}
		
		//end of the step
		if (boolRight5 == true)
		{
			stepText.text = "You said the fuck word and took a step foward!";
			tinyStepCount = 0;
			Global.me.stepsLeft -= 1;
			boolRight1 = false;
			boolRight2 = false;
			boolRight3 = false;
			boolRight4 = false;
			leftActive = true;
			rightActive = false;
			boolRight5 = false;
		}
	}


//______________________________________________________________________________________________________________
	
	//left movement
	public void leftMovement()
	{
		//counter for the tiny steps
		int tinyStepCount = 0;
		
		//first input
		if (Input.GetKey(left1) && Global.me.passedOut == false)
		{
			stepText.text = "";
			Timer.addTime();
			Debug.Log("1");
			boolLeft1 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepLeftFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolLeft1 = false;
			GetComponent<MovingFeet>().tinyStepLeftBac(tinyStepCount);
		}
		
		//second input
		if (Input.GetKey(left2) && boolLeft1 == true && Global.me.passedOut == false)
		{
			Debug.Log("2");
			boolLeft2 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepLeftFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolLeft2 = false;
			GetComponent<MovingFeet>().tinyStepLeftBac(tinyStepCount); //moving the foot
		}
		
		//third input
		if (Input.GetKey(left3) && boolLeft2 == true  && Global.me.passedOut == false)
		{
			Debug.Log("3");
			boolLeft3 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepLeftFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolLeft3 = false;
			GetComponent<MovingFeet>().tinyStepLeftBac(tinyStepCount); //moving the foot
		}
		
		//fourth input
		if (Input.GetKey(KeyCode.Q) && boolLeft3 == true && Global.me.passedOut == false)
		{
			Debug.Log("4");
			boolLeft4 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepLeftFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolLeft4 = false;
			GetComponent<MovingFeet>().tinyStepLeftBac(tinyStepCount); //moving the foot
		}
		
		//fifth input
		if (Input.GetKey(KeyCode.H) && boolLeft4 == true && Global.me.passedOut == false)
		{
			Debug.Log("5");
			boolLeft5 = true;
			tinyStepCount += 1;
			GetComponent<MovingFeet>().tinyStepLeftFow(tinyStepCount); //moving the foot
		}
		else
		{
			boolLeft5 = false;
			GetComponent<MovingFeet>().tinyStepLeftBac(tinyStepCount); //moving the foot
		}
		
		//end of the step
		if (boolLeft5 == true)
		{
			stepText.text = "You said the fuck word and took a step foward!";
			tinyStepCount = 0;
			Global.me.stepsLeft -= 1;
			boolLeft1 = false;
			boolLeft2 = false;
			boolLeft3 = false;
			boolLeft4 = false;
			rightActive = true;
			leftActive = false;
			boolLeft5 = false;
		}
			
	}
	
}
