using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    Vector3 direcctionToTarget;
    public GameObject explosion;


	void Start () {
        target = GameObject.Find("sleeper");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 3f);
    }


    void Update()
    {
        MoveEnemy();

    }

    void OnTriggerEnter2D (Collider2D col){

        switch (col.gameObject.tag){

            case "sleeper":
                EnemiesSpawnerControl.spaqnAllowed = false;
                Instantiate(explosion, col.gameObject.transform.position, Quaternion.identity);
                Destroy(col.gameObject);
                target = null;
                break;
        }


    }

    void MoveEnemy(){
        if (target != null){
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed);
        } else{
            rb.velocity = Vector3.zero;
        }

    }

}

