using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

    public Transform[] SpawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomEnemy;
    public static bool spawnAllowed;

	// Use this for initialization
	void Start () {
        spawnAllowed = true;
        InvokeRepeating("SpawnEnemies", 0f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy(){

        if(spawnAllowed){
            randomSpawnPoint = Random.Range(0, SpawnPoints.Length);
            randomEnemy = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomEnemy], SpawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
