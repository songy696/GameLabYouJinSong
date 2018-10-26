using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAsteroids : MonoBehaviour {

    public GameObject Ateroids;

    float Timer = 0;

	// Use this for initialization
	void Start () {
        //Vector3 position = new Vector3(Random.Range(-10.5f, 10.5f), Random.Range(5f, -5f), 0);
        //Instantiate(Ateroids, position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;

        Vector3 position = new Vector3(Random.Range(-10.5f, 10.5f), Random.Range(5f, -5f), 0);
        if (Timer >= 1f)
        {

            GameObject clone = Instantiate(Ateroids, position, Quaternion.identity);

            Timer = 0;
        }

        
    }

}
