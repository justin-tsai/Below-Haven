using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamera : MonoBehaviour {
	private Vector2 velocity;
	public float smoothTimeY;
	public float smoothTimeX;
	public GameObject player;
	private Vector3 startPos;
	private Vector3 endPos;
	private float distanceLeft = 8.5f;
	private float distanceDown = 1.4f;
	private float lerpTime = 8;
	private float currentLerpTime = 0;
    

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		endPos = transform.position + Vector3.left * distanceLeft;
		player = GameObject.FindGameObjectWithTag ("Player");
		//panRight ();
	}
	public void panRight()
	{
		currentLerpTime += Time.deltaTime;
		if (currentLerpTime >= lerpTime) {
			currentLerpTime = lerpTime;
		}
		float perc = currentLerpTime / lerpTime;
		transform.position = Vector3.Lerp (startPos, endPos, perc);

	}
	public void panDown(){
		currentLerpTime += Time.deltaTime;
		if (currentLerpTime >= lerpTime) {
			currentLerpTime = lerpTime;
		}
		float perc = currentLerpTime / lerpTime;
		transform.position = Vector3.Lerp (startPos, endPos + (Vector3.down * distanceDown) , perc);
	}
	void FixedUpdate(){
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);
		transform.position = new Vector3 (posX, posy, transform.position.z);

	}

	// Update is called once per frame
	void Update () {
		panRight ();
		panDown ();

	}
}
