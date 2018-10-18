using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootableMonster : MonoBehaviour {

    Transform trPlayer;
    float fRotSpeed = 3.0f;
    public float moveSpeed;
  

    public int currentHealth = 3;

    public void Damage (int damageAmount){
        currentHealth -= damageAmount;
        if (currentHealth <= 0){
            gameObject.SetActive(false);
        }
    }

    void Start()
    {
        trPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(trPlayer.position - transform.position), fRotSpeed * Time.deltaTime);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

}
