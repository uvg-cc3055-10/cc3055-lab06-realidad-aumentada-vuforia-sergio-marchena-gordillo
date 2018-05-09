using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//IMPLEMENTACION DEL VIRTUAL BUTTON HANDLER
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

	//BOTON VIRTUAL Y ANIMATOR
	private VirtualButtonBehaviour virtualBtn;
	public Animator birdAnim;
	// Use this for initialization

	//METODOS DE LA INTERFACE VIRTUALBUTTONBEHAVIOUR
	public void OnButtonPressed (VirtualButtonBehaviour vb) {
		birdAnim.SetTrigger("sing");

	}
	//METODOS DE LA INTERFACE VIRTUALBUTTONBEHAVIOUR
	public void OnButtonReleased(VirtualButtonBehaviour vb) {

	}

	void Start () {
		
		virtualBtn = GetComponent<VirtualButtonBehaviour>(); 
		//EL HANDLER DE LOS EVENTOS DEL BOTON
		virtualBtn.RegisterEventHandler(this);
	}


	
	// Update is called once per frame
	void Update () {
		
	}


}
