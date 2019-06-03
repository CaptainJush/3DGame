using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

	bool gameHasConcluded = false; 

	public float restartDelay = 1f; 

	public GameObject LevelCompleteUI; 

	public void CompleteLevel ()
	{
		LevelCompleteUI.SetActive(true); 
	}

	public void GameEnd ()
	{
		if (gameHasConcluded == false)
		{
			gameHasConcluded = true; 
			Debug.Log("Game Over"); 
			//Restarting game. 
			Invoke("RestartGame", restartDelay);
		}
		
	}

	void RestartGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
