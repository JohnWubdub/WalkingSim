﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFeet : MonoBehaviour {

	public GameObject rightFoot;
	public GameObject leftFoot;
	public GameObject head;
	public GameObject body;
	
	//Right foot
	public Vector3 startPos1RightFoot = new Vector3(0,0,0);
	public Vector3 startPos2RightFoot = new Vector3(0,0,0);
	public Vector3 startPos3RightFoot = new Vector3(0,0,0);
	
	//Left foot
	public Vector3 startPos1LeftFoot = new Vector3(0,0,0);
	public Vector3 startPos2LeftFoot = new Vector3(0,0,0);
	public Vector3 startPos3LeftFoot = new Vector3(0,0,0);

	//head
	public Vector3 startPos1Head = new Vector3(0,0,0);
	public Vector3 startPos2Head = new Vector3(0,0,0);
	public Vector3 startPos3Head = new Vector3(0,0,0);
	
	//body
	public Vector3 startPos1Body = new Vector3(0,0,0); 
	public Vector3 startPos2Body = new Vector3(0,0,0);
	public Vector3 startPos3Body = new Vector3(0,0,0);

	//movement stuff
	Vector3 tinyStepFow = new Vector3(-.15f, 0, 0); 
	Vector3 tinyStepBac = new Vector3(.15f, 0, 0);
	
	
	void Start () 
	{
		//feet
		startPos1RightFoot = rightFoot.transform.position; //right
		startPos1LeftFoot = leftFoot.transform.position; //left

		startPos2RightFoot = startPos1RightFoot + (tinyStepFow * 5); //right
		startPos2LeftFoot = startPos1LeftFoot + (tinyStepFow * 5); //left

		startPos3RightFoot = startPos2RightFoot + (tinyStepFow * 5); //right
		startPos3LeftFoot = startPos2LeftFoot + (tinyStepFow * 5);
		
		//head
		startPos1Head = head.transform.position + (tinyStepFow * 5);
		startPos2Head = startPos1Head + (tinyStepFow * 5);
		startPos3Head = startPos2Head + (tinyStepFow * 5);
		
		
		//body
		startPos1Body = body.transform.position + (tinyStepFow * 5);
		startPos2Body = startPos1Body + (tinyStepFow * 5);
		startPos3Body = startPos2Body + (tinyStepFow * 5);

	}

	void Update()
	{
		bigMove();
	}

//_________________________________________________________________________________________________________
	
	//Right Side
	public void tinyStepRightFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 6)
		{
			rightFoot.transform.position = startPos1RightFoot + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 4)
		{
			rightFoot.transform.position = startPos2RightFoot + (tinyStepFow * tinyStepCount);
		}
		
		if (Global.me.stepsLeft == 2)
		{
			rightFoot.transform.position = startPos3RightFoot + (tinyStepFow * tinyStepCount);
		}
	}
	
	
	public void tinyStepRightBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 6)
		{
			rightFoot.transform.position = startPos1RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 4)
		{
			rightFoot.transform.position = startPos2RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
		
		if (Global.me.stepsLeft == 2)
		{
			rightFoot.transform.position = startPos3RightFoot + (tinyStepFow * tinyStepCount) + tinyStepBac; 
		}
	}

	
//________________________________________________________________________________________________________________	

	//Left Side Now
	public void tinyStepLeftFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 5)
		{
			leftFoot.transform.position = startPos1LeftFoot + (tinyStepFow * tinyStepCount); 
		}

		if (Global.me.stepsLeft == 3)
		{
			leftFoot.transform.position = startPos2LeftFoot + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 1)
		{
			leftFoot.transform.position = startPos3LeftFoot + (tinyStepFow * tinyStepCount);
		}
		
	}
	
	public void tinyStepLeftBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 5)
		{
			leftFoot.transform.position = startPos1LeftFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 3)
		{
			leftFoot.transform.position = startPos2LeftFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
		
		if (Global.me.stepsLeft == 1)
		{
			leftFoot.transform.position = startPos3LeftFoot + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
	}

	public void bigMove()
	{
		if (Global.me.stepsLeft == 4)
		{
			head.transform.position = startPos1Head;
			body.transform.position = startPos1Body;
		}

		if (Global.me.stepsLeft == 2)
		{
			head.transform.position = startPos2Head;
			body.transform.position = startPos2Body;
		}
		
		if (Global.me.stepsLeft == 0)
		{
			head.transform.position = startPos3Head;
			body.transform.position = startPos3Body;
		}
	}
	
}
