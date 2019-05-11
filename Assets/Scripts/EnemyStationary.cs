using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStationary : MonoBehaviour {
    public int xMoveDirection;
    public bool EcounterPlayer = false;
    // Use this for initialization
    public int stationaryHealth = 3;
    public GameObject enemy;
    public GameObject health;
    // Update is called once per frame
    void Update()
    {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
            /*if (hit.collider.tag == "Player" && hit.distance < 1.2)
            {
                //Destroy(gameObject);
                GameObject.Find("Warrior").GetComponent<Player_Health>().Health -= 1; 
            }*/
        
        if(stationaryHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        stationaryHealth -= damage;
		StartCoroutine(Flash (0.05f));
        health.GetComponent<TMPro.TextMeshPro>().text = "-" + damage;
        //print(stationaryHealth);
    }

	    IEnumerator Flash(float x){
		        Debug.Log ("Flashing");
		        //this.GetComponent<BoxCollider2D> ().enabled = false;
		        for (int i = 0; i < 2; i++) {
			this.GetComponent<SpriteRenderer>().enabled = false;
			            yield return new WaitForSeconds (x);
			this.GetComponent<SpriteRenderer>().enabled = true;
			            yield return new WaitForSeconds (x);
			        }
		        //this.GetComponent<BoxCollider2D> ().enabled = true;
		    } 
}
