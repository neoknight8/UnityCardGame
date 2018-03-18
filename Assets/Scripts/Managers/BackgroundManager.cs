using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : SingletonMonoBehaviour<BackgroundManager> {

	private GameObject panel;
	private Animator animator;
	private bool isInAction;
	private FadeInFinishedListener fadeInListener;
	private FadeOutFinishedListener fadeOutListener;
	[SerializeField]
	string[] animator_bools;

	// Use this for initialization
	void Start () {
		isInAction = false;
		panel = GameObject.FindGameObjectWithTag ("panel");
		animator = panel.GetComponent<Animator> ();
	}


	public void setFadeOutFinishedListener(FadeOutFinishedListener listener){
		fadeOutListener = listener;
	}

	public void setFadeInFinishedListener(FadeInFinishedListener listener){
		fadeInListener = listener;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fadeIn(){
		if (!isInAction) {
			isInAction = true;
			animator.SetBool ("fadeIn", true);
		}
	}

	public void fadeOut(){
		if (!isInAction) {
			isInAction = true;
			animator.SetBool ("fadeOut", true);
		}
	}

	public void setIsInAction(bool _bool){
		isInAction = _bool;
	}

	public void resetBools(){
		foreach (string boolname in animator_bools) {
			animator.SetBool (boolname, false);
		}
	}

	public void fadeOutFinished(){
		fadeOutListener.fadeOutFinished ();
		resetBools ();
		setIsInAction (false);
		animator.SetBool ("stayDark", true);
	}

	public void fadeInFinished(){
		fadeInListener.fadeInFinished ();
		resetBools ();
		setIsInAction (false);
		animator.SetBool ("stayClear", true);
	}

	public interface FadeInFinishedListener{
		void fadeInFinished();
	}

	public interface FadeOutFinishedListener{
		void fadeOutFinished();
	}
}
