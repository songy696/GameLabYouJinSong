using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 2.5f;
    private Transform target;

    public int CurrentHealth;
    public int MaxHealth;


    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("sleeper").GetComponent<Transform>();
        CurrentHealth = MaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
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

}
