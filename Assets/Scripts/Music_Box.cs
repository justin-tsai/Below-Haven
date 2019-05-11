using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Box : MonoBehaviour {

	public AudioSource level0;
	public AudioSource level1;
	public AudioSource level2;

	public void Lv0toLv1(){
		level1.Play ();
	}

	public void Lv1toLv2(){
		level2.Play ();
	}
}
