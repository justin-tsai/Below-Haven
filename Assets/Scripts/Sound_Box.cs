using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Box : MonoBehaviour {

	public AudioSource jumpSound;
	public AudioSource enemyKillSound;
	public AudioSource coinSound;
	public AudioSource slash1Sound;

	public void playJumpSound(){
		jumpSound.Play ();
	}

	public void playEnemyKillSound(){
		enemyKillSound.Play ();
	}

	public void playCoinSound(){
		coinSound.Play ();
	}

	public void playSlash1Sound(){
		slash1Sound.Play ();
	}
		


}
