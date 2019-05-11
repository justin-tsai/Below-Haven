using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {
    //public int depth;
    public bool hasDied = false;
    public bool level0;
    public bool level1;
    public bool level2;
    public float Health;
    private float timerHit = 2.0f;
    //private string collide;
    // Use this for initialization
    void Start () {
        hasDied = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health <= 0) //gameObject.transform.position.y < -(depth))
        {
            hasDied = true;
        }
        if (hasDied == true)
        {
            Debug.Log("hi");
            StartCoroutine("Die");
        }
        


    }

    IEnumerator Die()
    {
        if (level0 == true)
        {
            SceneManager.LoadScene("Charly Dang Level 0");
        }
        else if (level1 == true)
        {
            SceneManager.LoadScene("Level 1");
        }
        else if (level2 == true)
        {
            SceneManager.LoadScene("Level 2");
        }
        yield return null;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            while(timerHit > 0)
            {
                timerHit -= Time.deltaTime;
            }
            Health -= 1f;
            
            
        }
    }
    

}
