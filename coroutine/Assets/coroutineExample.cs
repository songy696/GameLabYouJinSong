using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutineExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("myCoroutine");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator muCoroutine(){
        //do something 

        //wait for couple of seconds

        yield return new WaitForSeconds(2);
        // do something else
        yield return null;
        // rests the thing
       
    }
}
