using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float rotationSpeed = 100f;
    float thrustForce = 3f;

    public GameObject bullet;

    void Start()
    {
    }

    void FixedUpdate()
    {

        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);

        GetComponent<Rigidbody2D>().AddForce(transform.up  * Input.GetAxis("Vertical"));

        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag != "Bullet")
        {

            transform.position = new Vector3(0, 0, 0);

            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

        }
    }

    void ShootBullet()
    {

        Instantiate(bullet,new Vector3(transform.position.x, transform.position.y, 0),transform.rotation);

    }
}
//    public int speed;
//    public float turnSpeed;
//    float angle;
//    Vector3 myPos;
//    Transform myTrans;

//    float InputX;
//    float InputY;

//    // Use this for initialization
//    void Start()
//    {
//        laserLine = GetComponent<LineRenderer>();

//        //myTrans = transform;
//        //myPos = myTrans.position;
//    }

//    // Update is called once per frame
//    void Update()
//    {

//        InputX = Input.GetAxis("Horizontal");
//        InputY = Input.GetAxis("Vertical");


//        if (Input.GetKey(KeyCode.RightArrow))
//        {
//            Vector3 newRotation = transform.rotation.eulerAngles;
//            newRotation.z += 10;
//            transform.rotation = Quaternion.Euler(newRotation);
//        }
//        else if (Input.GetKey(KeyCode.LeftArrow))
//        {
//            Vector3 newRotation = transform.rotation.eulerAngles;
//            newRotation.z -= 10;
//            transform.rotation = Quaternion.Euler(newRotation);
//        }

//        if (Input.GetKey(KeyCode.UpArrow))
//        {
//            Vector3 position = this.transform.position;
//            position.y += speed;
//            this.transform.position = position;
//        }
//    }
//    //void FixedUpdate()
//    //{

//        //if (InputX != 0)
//        //{
//        //    transform.Rotate(-Vector3.forward * InputX);
//        //}

//        //if (InputY != 0)
//        //{
//        //    transform.Translate(transform.up * InputY);
//        //}

//        //angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;

//        ////move object Forward & Backward
//        //if (Input.GetKey(KeyCode.UpArrow))
//        //{

//        //    myPos.x += (Mathf.Cos(angle) * speed) * Time.deltaTime;
//        //    myPos.y += (Mathf.Sin(angle) * speed) * Time.deltaTime;
//        //}
//        //if (Input.GetKey(KeyCode.DownArrow))
//        //{
//        //    myPos.x += Mathf.Cos(angle) * Time.deltaTime;
//        //    myPos.y += Mathf.Sin(angle) * Time.deltaTime;
//        //}


//        ////Apply
//        //myTrans.position = myPos;


//    //}
//}
