using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public static ChangeScene changeScene;

	public void Start()
	{
		changeScene = this;
	}

	public void ChangeToScene(int changeTheScene) {

		SceneManager.LoadScene (changeTheScene);
	}
}