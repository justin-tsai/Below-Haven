using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour {

    private bool attacking = false;
    private float attackTimer = 0;
    private float attack1cd = .5f;
    private float attack2cd = 3f;
    private float attack3cd = 5f;

    private string s;
    public Collider2D attackTrigger;
	public GameObject soundBox;
    //public int dmg = 1;
    private void Start()
    {
         
    }
    private Animator anim;
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown("q") && !attacking && anim.GetBool("Run") == false)
        {
			soundBox.GetComponent<Sound_Box> ().playSlash1Sound ();
            //print("attacking");
            attacking = true;
            attackTimer = attack1cd;
            attackTrigger.GetComponent<attackTrigger>().dmg = 1;
            attackTrigger.enabled = true;
            print(attackTrigger.enabled);
            
            s = "q";
        }
        if (Input.GetKeyDown("w") && !attacking && anim.GetBool("Run") == false)
        {
			soundBox.GetComponent<Sound_Box> ().playSlash1Sound ();
            //print("attacking");
            attacking = true;
            attackTimer = attack1cd;
            attackTrigger.GetComponent<attackTrigger>().dmg = 2;
            attackTrigger.enabled = true;
            print(attackTrigger.enabled);
            
            s = "w";
        }
        if (Input.GetKeyDown("e") && !attacking && anim.GetBool("Run") == false)
        {
			soundBox.GetComponent<Sound_Box> ().playSlash1Sound ();
            //print("attacking");
            attacking = true;
            attackTimer = attack1cd;
            attackTrigger.GetComponent<attackTrigger>().dmg = 4;
            attackTrigger.enabled = true;
            print(attackTrigger.enabled);
            
            
            s = "e";
        }
        if (attacking)
        {
            if (s.Equals("q"))
            {
                anim.SetBool("attack1", true);
                //print("attack1 hit");
                if (attackTimer > 0)
                {
                    attackTimer -= Time.deltaTime;
                    
                }
                else
                {
                    attacking = false;
                    anim.SetBool("attack1", false);
                    attackTrigger.enabled = false;
                    print(attackTrigger.enabled);
                }
            }
            else
            if (s.Equals("w"))
            {
                anim.SetBool("attack2", true);
                //print("attack2 hit");
                if (attackTimer > 0)
                {
                    attackTimer -= Time.deltaTime;
                    
                }
                else
                {
                    attacking = false;
                    anim.SetBool("attack2", false);
                    attackTrigger.enabled = false;
                    print(attackTrigger.enabled);
                }
            }
            else
            if (s.Equals("e"))
            {
                anim.SetBool("attack3", true);
                //print("attack3 hit");
                if (attackTimer > 0)
                {
                    attackTimer -= Time.deltaTime;
                    
                }
                else
                {
                    attacking = false;
                    anim.SetBool("attack3", false);
                    attackTrigger.enabled = false;
                    print(attackTrigger.enabled);
                }
            }

        }
        
    }
}
