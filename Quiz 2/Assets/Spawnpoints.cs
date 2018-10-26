using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour {

	 public enum SpawnState { spawning, waiting, counting };

    [System.Serializable]

    public class Wave
    {
        public string name;
        public Transform asteroid;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountDown = 1f;

    public SpawnState state = SpawnState.counting;

    void Start()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced.");
        }

        waveCountdown = timeBetweenWaves;

    }

    void Update()
    {
        if(state == SpawnState.waiting){

            if(!EnemyIsAlive()){
                WaveCompleted();
                return;

            } else{
                return;
            }
        }

        if(waveCountdown <=0){
            if(state != SpawnState.spawning){
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else{
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveCompleted (){

        state = SpawnState.counting;
        waveCountdown = timeBetweenWaves;

        if(nextWave + 1> waves.Length - 1){
            nextWave = 0;
            Debug.Log("All waves completed! looping...");
        }
        else{
            nextWave++;
        }

    }

    bool EnemyIsAlive(){
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0f)
        {
            searchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Asteroid") == null)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave){
   
        state = SpawnState.spawning;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.asteroid);
            yield return new WaitForSeconds(1f / _wave.rate);
        }
        //spawn
        state = SpawnState.waiting;

        yield break;
    }

    void SpawnEnemy (Transform _enemy){
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, spawnPoints[Random.Range(0,spawnPoints.Length)].position, transform.rotation);

    }

}
