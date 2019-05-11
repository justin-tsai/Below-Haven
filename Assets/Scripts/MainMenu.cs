using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		SceneManager.LoadScene(1); 
        //if only want to load first level not current level.
	}

	public void QuitGame()
	{
		Debug.Log ("QUIT");
		Application.Quit ();
	}
}
