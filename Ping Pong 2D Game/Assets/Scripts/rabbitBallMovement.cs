using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class rabbitBallMovement : MonoBehaviour {

    public float ballForce;
    public Rigidbody2D rb;
    bool gameStarted = false;
    private int count;
    SpriteRenderer sr;
    public Sprite lookOuch;
    public Sprite lookNormal;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        count = 0;
    }

    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Space) && gameStarted == false){

            transform.SetParent(null);
            rb.isKinematic = false;

            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)     {         if (col.gameObject.CompareTag("pickups"))         {
            sr.sprite = lookOuch;             Destroy(col.gameObject);
            count = count + 1;         } else {
            sr.sprite = lookNormal;
        }

        if (count >= 31)         {             SceneManager.GetSceneByName("manu");         }      }  

}
