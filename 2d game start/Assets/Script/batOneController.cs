using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batOneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float speed;
    public Rigidbody rb;

	// Update is called once per frame
	void Update () {

        rb.velocity = new Vector2(0f, Input.GetAxis("Vertical")) * speed;

        if (Input.GetKey(KeyCode.W) && this.transform.position.y < 2.3f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 5f);
        }
        else if(Input.GetKey(KeyCode.S) && this.transform.position.y > - 2.3f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, -5f);
        }
        else this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
	}
}
