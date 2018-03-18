using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventUtil : MonoBehaviour {
	[SerializeField]
	private UnityEvent onAnimationFinished;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void animationFinished(){
		onAnimationFinished.Invoke ();
	}
}
