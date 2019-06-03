using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	//A reference to Rigibody. 
	public Rigidbody ab;

	public float Forceforwards = 2000f;
	public float Forcesideways = 500f;

	//This method is called "FixedUpdate" as we are using it
	//to manipulate physics. 
	void FixedUpdate () 
	{
		
		ab.AddForce(0, 0, Forceforwards * Time.deltaTime); //Forceforwards is added

		if (Input.GetKey("d")) 
		{
			ab.AddForce(Forcesideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
		}

		if (Input.GetKey("a"))
		{
			ab.AddForce(-Forcesideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
		}

		if (ab.position.y < -1f)
		{
			FindObjectOfType<GameManager>().GameEnd();
		}

	}
}
