using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : SingletonMonoBehaviour<SceneLoader>{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadCardMenuScene(){
		BackgroundManager.Instance.setFadeOutFinishedListener(
			new FadeOutFinishedListener()
		);
		BackgroundManager.Instance.fadeOut ();
	}

	class FadeOutFinishedListener : BackgroundManager.FadeOutFinishedListener{
		public void fadeOutFinished (){
			SceneManager.LoadScene ("CardMenu");
		}
	}
}
