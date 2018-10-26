using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * 400);
        Destroy(gameObject, 1.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(other.gameObject);
        }
    }
}
