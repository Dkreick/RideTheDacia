using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
	
	public void ChangeScene(string sceneName)
	{
		
	}

	public void QuitGame()
	{
		Application.Quit ();
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
