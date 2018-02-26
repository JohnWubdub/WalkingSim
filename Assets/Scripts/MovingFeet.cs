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
	
	//foots
	public Vector3 startPos1Foot = new Vector3(0,0,0);
	public Vector3 startPos2Foot = new Vector3(0,0,0);
	public Vector3 startPos3Foot = new Vector3(0,0,0);
	public Vector3 startPos4Foot = new Vector3(0,0,0);
	public Vector3 startPos5Foot = new Vector3(0,0,0);
	
	//legs
	public Vector3 startPos1Leg = new Vector3(0,0,0);
	public Vector3 startPos2Leg = new Vector3(0,0,0);
	public Vector3 startPos3Leg = new Vector3(0,0,0);
	public Vector3 startPos4Leg = new Vector3(0,0,0);
	public Vector3 startPos5Leg = new Vector3(0,0,0);
	
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
		startPos1Foot = rightFoot.transform.position; //right
		startPos2Foot = leftFoot.transform.position; //left
		startPos3Foot = startPos1Foot + (tinyStepFow * 5); //right
		startPos4Foot = startPos2Foot + (tinyStepFow * 5); //left
		startPos5Foot = startPos3Foot + (tinyStepFow * 5); //right
		
		//legs
		startPos1Leg = rightLeg.transform.position; //right
		startPos2Leg = leftLeg.transform.position; //left
		startPos3Leg = startPos1Leg + (tinyStepFow * 5); //right
		startPos4Leg = startPos2Leg + (tinyStepFow * 5); //left
		startPos5Leg = startPos3Leg + (tinyStepFow * 5); //right
		
		//head
		startPos1Head = head.transform.position;
		startPos2Head = head.transform.position + (tinyStepFow * 5);
		startPos3Head = head.transform.position + (tinyStepFow * 10);
		
		
		//body
		startPos1Body = body.transform.position;
		startPos1Body = body.transform.position + (tinyStepFow * 5);
		startPos1Body = body.transform.position + (tinyStepFow * 10);

	}

	
	//Right Side
	public void tinyStepRightFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 5)
		{
			rightFoot.transform.position = startPos1Foot + (tinyStepFow * tinyStepCount);
			rightLeg.transform.position = startPos1Leg + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 3)
		{
			rightFoot.transform.position = startPos3Foot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos3Leg + (tinyStepFow * tinyStepCount);
		}
		
		if (Global.me.stepsLeft == 1)
		{
			rightFoot.transform.position = startPos5Foot + (tinyStepFow * tinyStepCount);
			rightLeg.transform.position = startPos5Leg + (tinyStepFow * tinyStepCount);
		}
	}
	
	public void tinyStepRightBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 5)
		{
			rightFoot.transform.position = startPos1Foot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos1Leg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 3)
		{
			rightFoot.transform.position = startPos3Foot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos3Leg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
		
		if (Global.me.stepsLeft == 1)
		{
			rightFoot.transform.position = startPos5Foot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			rightLeg.transform.position = startPos5Leg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}
	}
	
//________________________________________________________________________________________________________________	

	//Left Side Now
	public void tinyStepLeftFow(int tinyStepCount) //taking a step foward
	{
		if (Global.me.stepsLeft == 4)
		{
			leftFoot.transform.position = startPos2Foot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos2Leg + (tinyStepFow * tinyStepCount);
		}

		if (Global.me.stepsLeft == 2)
		{
			leftFoot.transform.position = startPos4Foot + (tinyStepFow * tinyStepCount);
			leftLeg.transform.position = startPos4Leg + (tinyStepFow * tinyStepCount);
		}
		
	}
	
	public void tinyStepLeftBac(int tinyStepCount) //taking a step back
	{
		if (Global.me.stepsLeft == 4)
		{
			leftFoot.transform.position = startPos1Foot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			leftLeg.transform.position = startPos1Leg + (tinyStepFow * tinyStepCount) + tinyStepBac;
		}

		if (Global.me.stepsLeft == 2)
		{
			leftFoot.transform.position = startPos4Foot + (tinyStepFow * tinyStepCount) + tinyStepBac;
			leftLeg.transform.position = startPos4Leg + (tinyStepFow * tinyStepCount) + tinyStepBac;
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
