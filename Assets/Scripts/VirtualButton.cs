using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

	private VirtualButtonBehaviour virtualBtn;
	public Animator birdAnim;
	//public AudioSource aux;
	// Use this for initialization

	public void OnButtonPressed (VirtualButtonBehaviour vb) {
		birdAnim.SetTrigger("sing");

	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) {

	}

	void Start () {
		virtualBtn = GetComponent<VirtualButtonBehaviour>(); 
		virtualBtn.RegisterEventHandler(this);
	}


	
	// Update is called once per frame
	void Update () {
		
	}


}
