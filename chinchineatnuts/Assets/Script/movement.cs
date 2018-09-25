using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour {


    public float moveSpeed;
    public float speed;
    public float turnSpeed;
    public float upforce;
    public Text countText;
    public Text winText;

    public bool onGround;

    private Rigidbody rb;
    private int count;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

   
        moveSpeed = 30f;
        turnSpeed = 100f;
        speed = 20f;
        upforce = 10f;

        onGround = true;

        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";

    }

    // Update is called once per frame
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

        //if (Input.GetKey(KeyCode.Space)){
        //    GetComponent<Rigidbody>().AddForce(Vector3.down * upforce, ForceMode.Impulse);
        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    if (Input.GetButtonUp("Jump"))
        //    {
        //        rb.velocity = new Vector3(0f, 5f, 0f);
        //        onGround = false;
        //    }
        //}



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
        if (count >= 10)
        {
            winText.text = "You Win!";
        }
    }
}
