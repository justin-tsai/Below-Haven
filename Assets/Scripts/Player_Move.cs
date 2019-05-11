using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour {
    public int playerSpeed = 5;
    private bool facingRight = false;
    public int playerJumpePower = 1250;
    private float moveX;
    public bool isGrounded;
	private bool ceilingHit;
	private Animator anim;
    public int playerscore = 0;
    public bool level0;
    public bool level1;
    public bool level2;
	public GameObject soundBox;

    void Awake() {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		PlayerMove ();
        
	}

    void PlayerMove()
	{
		if (isGrounded == true) {
			anim.SetBool ("Fall", false);
			ceilingHit = false;
		}
		//Controls
			moveX = Input.GetAxis ("Horizontal");
			//Animations
			//PlayerMove Direction 
			if (moveX < 0.0f) {
				if (facingRight == false) {
					FlipPlayer ();
				}
				anim.SetBool ("Run", true);
			
			} else if (moveX > 0.0f) {
				if (facingRight == true) {
					FlipPlayer ();
				}
				anim.SetBool ("Run", true);
			} else {
				anim.SetBool ("Run", false);
			}
				
			//physics
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);

		if (Input.GetButtonDown ("Jump") && isGrounded == true) {
			Jump ();
		}

		if (isGrounded == false) {
			if (gameObject.GetComponent<Rigidbody2D> ().velocity.y > 0) {
				if (ceilingHit == true) {
					//Debug.Log ("Player is falling.");
					anim.SetBool ("Jump", false);
					anim.SetBool ("Fall", true);
				} else {
					//Debug.Log ("Player is jumping.");
					anim.SetBool ("Jump", true);
					anim.SetBool ("Fall", false);
				}

			} else {
				//Debug.Log ("Player is falling.");
				anim.SetBool ("Jump", false);
				anim.SetBool ("Fall", true);
			}
		}
		if (gameObject.GetComponent<Rigidbody2D> ().velocity.y < 0) {
			anim.SetBool ("Fall", true);
		}
	}

    void Jump()
    {
        //Jumping Code
		//Debug.Log("Setting jump bool to true.");
		soundBox.GetComponent<Sound_Box> ().playJumpSound ();
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpePower);
        isGrounded = false;
		anim.SetBool ("Jump", true);
		anim.SetBool ("Run", true);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Player has collided with " + col.collider.name);

        if (col.gameObject.tag == "Enemy")
        {
			
        }

        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
			ceilingHit = true;
			anim.SetBool ("Fall", true);
			anim.SetBool ("Jump", false);
        }


        if (col.gameObject.tag == "EndLevel")
        {
            if (level0 == true)
            {
                //Application.LoadLevel("Kevin Nguyen");
                //SceneManager.LoadScene("Charly Dang Level 0");
                SceneManager.LoadScene("Level 1");
            }
            else if (level1 == true)
            {
                SceneManager.LoadScene("Level 2");
            }
            else if (level2 == true)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

}
