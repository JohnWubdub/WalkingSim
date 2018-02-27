using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFeet : MonoBehaviour {

	public GameObject rightFoot;
	public GameObject leftFoot;
	public GameObject rightLeg;
	public GameObject leftLeg;
	public GameObject head;
	public GameObject body;
	
	//Right foot
	public Vector3 startPos1RightFoot = new Vector3(0,0,0);
	public Vector3 startPos2RightFoot = new Vector3(0,0,0);
	public Vector3 startPos3RightFoot = new Vector3(0,0,0);
	
	//Left foot
	public Vector3 startPos1LeftFoot = new Vector3(0,0,0);
	public Vector3 startPos2LeftFoot = new Vector3(0,0,0);
	
	//Right leg
	public Vector3 startPos1RightLeg = new Vector3(0,0,0);
	public Vector3 startPos2RightLeg = new Vector3(0,0,0);
	public Vector3 startPos3RightLeg = new Vector3(0,0,0);
	
	//Left leg
	public Vector3 startPos1LeftLeg = new Vector3(0,0,0);
	public Vector3 startPos2LeftLeg = new Vector3(0,0,0);

	//head
	public Vector3 startPos1Head = new Vector3(0,0,0);
	public Vector3 startPos2Head = new Vector3(0,0,0);
	public Vector3 startPos3Head = new Vector3(0,0,0);
	
	//body
	public Vector3 startPos1Body = new Vector3(0,0,0);
	public Vector3 startPos2Body = new Vector3(0,0,0);
	public Vector3 startPos3Body = new Vector3(0,0,0);

	//movement stuff
	public Vector3 tinyStepFow = new Vector3(-.1f, 0, 0);
	public Vector3 tinyStepBac = new Vector3(.1f, 0, 0);
	
	
	void Start () 
	{
		//feet
		startPos1RightFoot = rightFoot.transform.position; //right
		startPos1LeftFoot = leftFoot.transform.position; //left

		startPos2RightFoot = startPos1RightFoot + (tinyStepFow * 5); //right
		startPos2LeftFoot = startPos1LeftFoot + (tinyStepFow * 5); //left

		startPos3RightFoot = startPos2RightFoot + (tinyStepFow * 5); //right
		
		//legs
		startPos1RightLeg = rightLeg.transform.position; //right
		startPos1LeftLeg = leftLeg.transform.position; //left
		
		startPos2RightLeg = startPos1RightLeg + (tinyStepFow * 5); //right
		startPos2LeftLeg = startPos1LeftLeg + (tinyStepFow * 5); //left
		
		startPos3RightLeg = startPos2RightLeg + (tinyStepFow * 5); //right
		
		//head
		startPos1Head = head.transform.position;
		startPos2Head = head.transform.position + (tinyStepFow * 5);
		startPos3Head = head.transform.position + (tinyStepFow * 10);
		
		
		//body
		startPos1Body = body.transform.position;
		startPos1Body = body.transform.position + (tinyStepFow * 5);
		startPos1Body = body.transform.position + (tinyStepFow * 10);

	}

	void Update()
	{
		bigMove();
	}

//_________________________________________________________________________________________________________
	
	//Right Side
	public void tinyStepRightFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 5)
		{
			rightFoot.transform.position = startPos1RightFoot + (tinyStepFow * tinyStepCount);
			rightLeg.transform.position = startPos1RightLeg + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 3)
		{
			rightFoot.transform.position = startPos2RightFoot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos2RightLeg + (tinyStepFow * tinyStepCount);
		}
		
		if (Global.me.stepsLeft == 1)
		{
			rightFoot.transform.position = startPos3RightFoot + (tinyStepFow * tinyStepCount);
			rightLeg.transform.position = startPos3RightLeg + (tinyStepFow * tinyStepCount);
		}
	}
	
	public void tinyStepRightBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 5)
		{
			rightFoot.transform.position = startPos1RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos1RightLeg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 3)
		{
			rightFoot.transform.position = startPos2RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos2RightLeg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
		
		if (Global.me.stepsLeft == 1)
		{
			rightFoot.transform.position = startPos3RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos3RightLeg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
	}
	
//________________________________________________________________________________________________________________	

	//Left Side Now
	public void tinyStepLeftFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 4)
		{
			leftFoot.transform.position = startPos1LeftFoot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos1LeftLeg + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 2)
		{
			leftFoot.transform.position = startPos2LeftFoot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos2LeftLeg + (tinyStepFow * tinyStepCount);
		}
		
	}
	
	public void tinyStepLeftBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 4)
		{
			leftFoot.transform.position = startPos1LeftFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			leftLeg.transform.position = startPos1LeftLeg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 2)
		{
			leftFoot.transform.position = startPos2LeftFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			leftLeg.transform.position = startPos2LeftLeg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
		
	}

	public void bigMove()
	{
		if (Global.me.stepsLeft == 3)
		{
			head.transform.position = startPos2Head;
			body.transform.position = startPos2Body;
		}

		if (Global.me.stepsLeft == 1)
		{
			head.transform.position = startPos3Head;
			body.transform.position = startPos3Body;
		}
	}
	
}
