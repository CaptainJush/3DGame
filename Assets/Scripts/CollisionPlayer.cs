using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour {

	public MovePlayer movement; 
	public GameManager GameMan; 

	//This function operates in the event our player hits an object. 
	//Information about the collision is recieved, we dub it "collisionInfo. 

	void OnCollisionEnter (Collision colisionInfo)
	{	
		//Checks if the object collided into has a tag of "Obstacle" 
		if(colisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false; //Player movement is disabled.  
			FindObjectOfType<GameManager>().GameEnd(); 
		}
	}
}
