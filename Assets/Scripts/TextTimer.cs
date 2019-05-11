using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour {

	// Use this for initialization
	public Text canvasText;
	public float timeToAppear;
	public float timeToDissapear;


	void Start () {
		canvasText.enabled = false;
		Invoke ("EnableText",timeToAppear);
		Invoke ("DisableText", timeToDissapear);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void EnableText(){
		canvasText.enabled = true;
		
		}

	void DisableText(){
		canvasText.enabled = false;
		
	}
}
