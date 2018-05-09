using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	// variables animacion y de audio
    Animator anim;
    AudioSource audios;


	// Use this for initialization
	void Start () {
		//animacion y audio
        anim = GetComponent<Animator>();
        audios = GetComponent<AudioSource>();
	}


    void ResetHopInt()
    {
        anim.SetInteger("hop", 0);
    }

	//ESCUCHAR CANCION
    void PlaySong()
    {
        audios.Play();
    }

}
