using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float speed = 2.5f;
    private Transform target;

    public int CurrentHealth;
    public int MaxHealth;

    public int damageToGive;




    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("sleeper").GetComponent<Transform>();
        CurrentHealth = MaxHealth;




    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);

        }

    }

   
    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.CompareTag("sleeper")){
    //        gameOverText.SetActive(true);
    //        restartButton.SetActive(true);
    //        gameObject.SetActive(false);
    //    }
    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "sleeper")
    //    {

    //        //FindObjectOfType<RestartScript>().EndGame();
    //    }
    //}



    //void OnTriggerEnter2D(Collider2D other)
    //{

    //    if (other.gameObject.CompareTag("sleeper"))
    //    {
    //        SceneManager.LoadScene("MenuScene");
    //    }
    //}

}
