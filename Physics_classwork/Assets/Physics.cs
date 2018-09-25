using UnityEngine;

public class Physics : MonoBehaviour
{

    void Start()
    {

    }


    void OnCollisionEnter(Collision other)
    {
        Debug.Log("I touched something!");
        if (other.gameObject.tag == "sphere")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("I'm still touching!");
        if (other.gameObject.tag == "sphere") { 
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("No longer touching");
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }


    public float upforce;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce,ForceMode.Impulse);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }


    void OnTriggerEnter(Collider other)
    {

    }

    void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }

    void OnTriggerExit(Collider other)
    {

    }



}