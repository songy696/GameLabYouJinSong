using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRaycast : MonoBehaviour {

    public float height = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit; // position, down, hit = if you hit something, you get the result of the sight back, height = max distance
        Debug.DrawRay (transform.position, Vector3.down * 5, Color.green); // if you want it to be infinite, but dont put any value at the back

        if(Physics.Raycast(transform.position, Vector3.down, out hit, height)){
            //Debug.Log("5 or less unites from ground");
            //Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "ground"){
                //do something
                GetComponent<MeshRenderer>().material.color = Color.blue;
                //color is in messhrenderer:)
            }
        }
	}
}
