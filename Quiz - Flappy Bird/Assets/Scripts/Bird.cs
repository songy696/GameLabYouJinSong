using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{


    Rigidbody2D rb;
    public float moveSpeed = 5f;
    //public float speed = 1f;
    public Text scoreText;
    public int scoring = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        //scoreText = GetComponent<scoreText>();

    }

    // Update is called once per frame
    void Update()
    {

        //scoreText.text = "Score: " + scoring.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene("SampleScene");

    }

    //I dont know how to do the scoring system!
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreZone"))
        {
            //other.gameObject.SetActive(false);
            scoring = scoring + 1;
            //SetCountText();
            scoreText.text = "Score : " + scoring.ToString();
        }

    }

    //void SetCountText()
    //{
    //    countText.text = "Count: " + count.ToString();

    //}
}