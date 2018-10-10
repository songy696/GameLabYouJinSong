using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector2(speed, 0f);

        } else if (Input.GetKey(KeyCode.LeftArrow)){

            rb.velocity = new Vector2(-speed, 0f);
        } else {

            rb.velocity = new Vector2(0f, 0f);
        }
		
	}

    void OnCollisionEnter(Collision col){
        foreach (ContactPoint contact in col.contacts){
            if(contact.thisCollider == GetComponent<BoxCollider>()){
                float calc = contact.point.x - transform.position.x;
                contact.otherCollider.GetComponent<Rigidbody>().AddForce(200f * calc, 0, 0);
            }
        }
    }
}
