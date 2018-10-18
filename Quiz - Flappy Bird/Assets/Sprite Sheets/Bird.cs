using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour {

    Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float speed = 1f;
    public Text countText;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

    }
	
	// Update is called once per frame
    void Update() {


        if (Input.GetMouseButtonDown (0)) {
         rb.AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
        }

	}

    void OnCollisionEnter2D(Collision2D coll){
        SceneManager.LoadScene("SampleScene");
    }

    //void SetCountText()     //{     //    countText.text = "Count: " + count.ToString();      //} 

}
