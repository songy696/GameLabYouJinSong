using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magiccube : MonoBehaviour {

    public GameObject magicCube;


	// Use this for initialization
	void Start () {
        for (int y = 0; y < 5; y++) 
        {
            for (int x = 0; x < 5; x++)
            {
                Instantiate(magicCube, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
