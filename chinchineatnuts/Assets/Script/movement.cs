using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movement : MonoBehaviour {


    public float moveSpeed;
    public float speed;
    public float turnSpeed;
    public float upforce;
    public Text countText;
    public Text winText;
    public Text timeText;
    private Text startTime;

    private float totalTime = 60f;
    public string levelToLoad;
    Text text;

    public bool onGround;

    private Rigidbody rb;
    private int count;

    void Start () {

        rb = GetComponent<Rigidbody>();

        moveSpeed = 30f;
        turnSpeed = 100f;
        speed = 20f;
        upforce = 10f;

        onGround = true;

        count = 0;
        SetCountText();
        winText.text = "";


    }


    public int sceneNum;

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);

        }

        //if (Input.GetKey(KeyCode.W))
        //{
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        //}


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        }



        totalTime -= Time.deltaTime;
        print(totalTime);
        timeText.text = "time is: " + totalTime.ToString();
        if (totalTime <= 0)
        {
            print("——————————— Oh no! Change Scene! ——————————— ——————————— ——————————— ");
            SceneManager.LoadScene(sceneNum);
        }


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUps"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "You Win!";
        }

        if (count >= 8){
            SceneManager.LoadScene(sceneNum);
        }
    }
}
