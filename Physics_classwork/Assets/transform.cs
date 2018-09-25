using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour {

    public float speed;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
      

	}

    public float upforce;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * upforce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * upforce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * upforce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * upforce, ForceMode.Impulse);
        }

    }


    // Update is called once per frame
    void Update () {
		
	}
}
