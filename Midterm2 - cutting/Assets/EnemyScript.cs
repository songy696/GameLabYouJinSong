using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public GameObject hurtEnemiesPrefab;
    //public float 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(collider2D col){

        if(col.tag == "Player"){

            GameObject hurtEnemies = Instantiate(hurtEnemiesPrefab);
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);
        }
    }
}
