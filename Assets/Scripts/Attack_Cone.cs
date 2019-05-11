using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Cone : MonoBehaviour {
    public Shooting_Plant shooting_Plant;

    void Awake()
    {
        shooting_Plant = gameObject.GetComponentInParent<Shooting_Plant>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shooting_Plant.Attack(true);
        }
    }

}
