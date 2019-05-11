using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour {
    public int EnemySpeed;
    public int xMoveDirection;
    public bool facingRight = false;
    public bool EcounterPlayer = false;
    public int curHealth;
    public GameObject enemy;
    public GameObject health;
    // Use this for initialization
    private void Start()
    {
        //curHealth = 3;
        
    }

    // Update is called once per frame
    void Update () {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * EnemySpeed;
            

            /*if (hit.collider.tag == "Player" && hit.distance < 1.8f)
            {
                Destroy(gameObject);
                GameObject.Find("Warrior").GetComponent<Player_Health>().Health -= 1; ;
            }*/ 
        if(curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Flip()
    {
        if (xMoveDirection > 0)
        {
            xMoveDirection *=-1;    
        } else
        {
            xMoveDirection *= -1;
        }
        FlipPlayer();
    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Enemy has hit the wall");
        
        if(col.gameObject.tag == "wall")
        {
            Flip();
            //health.GetComponent<RectTransform>().localScale.Set(,1,1);
        }
    }
    public void Damage(int damage){
        curHealth -= damage;
		StartCoroutine (Flash (0.05f));
        health.GetComponent<TMPro.TextMeshPro>().text = "-" + damage;
        print(curHealth);
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
