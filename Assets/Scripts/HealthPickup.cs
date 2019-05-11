using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

    private Player_Health lifeSystem;
    void Start()
    {
        lifeSystem = FindObjectOfType<Player_Health>();


}



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            GameObject.Find("Warrior").GetComponent<Player_Health>().Health += 1; ;
            Destroy(gameObject);
        }
    }
}