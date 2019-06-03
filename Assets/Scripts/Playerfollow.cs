using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfollow : MonoBehaviour {
	
	//Creating a variable to reference player. 
	public Transform player; 

	//Creating a variable to control camera position. 
	public Vector3 offset; 

	void Update () {

		transform.position = player.position + offset; 

	}
}
