using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float speed = 5f;
    float height = 0.5f;

	// Update is called once per frame
	void Update () {
        //transform.Rotate(0,0, Time.deltaTime * 100);
        //transform.Translate(0,Mathf.Sin(Time.time),0);
        //transform.Translate(Vector2.up * (Mathf.Sin(Time.time)/80));
        Vector2 pos = transform.position;
        float newY = Mathf.Sin(Time.time * speed)*0.25f;
        transform.position = new Vector2(pos.x, newY) * height;
    }
}
