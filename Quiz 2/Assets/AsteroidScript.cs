using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public GameObject Ateroids;

    public float speed = 2.5f;
    //private Transform target;

    public int CurrentHealth;
    public int MaxHealth;


    // Use this for initialization
    void Start()
    {
      
        GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-50.0f, 150.0f));

        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-0.0f, 90.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //if (CurrentHealth <= 0)
        //{
        //    Destroy(gameObject);
        //}

    }
    //public void HurtEnemy(int damageToGive)
    //{
    //    CurrentHealth -= damageToGive;
    //}

    //public void SetMaxHealth()
    //{
    //    CurrentHealth = MaxHealth;
    //}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }

        //if (tag.Equals("Asteroid")){
        //    Destroy(gameObject);
        //}
   }
}
