using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

//    Rigidbody2D rb;
//    GameObject target;
//    Vector3 directionToTarget;
//    GameObject wakeup;
//    GameObject hurt;
//    public float moveSpeed;


//	void Start () {
//        target = GameObject.Find("sleeper");
//        rb = GetComponent<Rigidbody2D>();

//    }


//    void Update()
//    {

//        MoveEnemy();

//    }

//    void OnTriggerEnter2D (Collider2D col){

//        switch (col.gameObject.tag){

//            case "sleeper":
//                enemySpawn.spawnAllowed = false;
//                Instantiate(wakeup,col.gameObject.transform.position, Quaternion.identity);
//                Destroy(col.gameObject);
//                target = null;
//                break;

//            case "Weapon":
//                Instantiate(hurt, col.transform.position, Quaternion.identity);
//                //KillsCounter.killsNumber += 1;
//                //Destory(col.gameObject);
//                Destroy(gameObject);
//                break;
//        }


//    }

//    private void Destory(object gameObject)
//    {
//        throw new NotImplementedException();
//    }

//    void MoveEnemy(){
//        if (target != null){
//            directionToTarget = (target.transform.position - transform.position).normalized;
//            rb.velocity = new Vector2(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed);
//        } else{
//            rb.velocity = Vector3.zero;
//        }

//    }

}

