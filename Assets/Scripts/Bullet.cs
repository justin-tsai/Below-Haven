using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    float counter = .05f;
    private void Update()
    {
        float destroyMe = 0;
        destroyMe += Time.deltaTime;
        if (destroyMe > counter)
        {
            Destroy(gameObject);
            destroyMe = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
