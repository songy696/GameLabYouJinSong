using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    public float speed = -1f;
    Vector3 startPosition;

    //public Renderer rend;

    void Start()
    {
        startPosition = transform.position;

    }

    void Update()
    {
        transform.Translate((new Vector3(1, 0, 0)) * speed * Time.deltaTime);

        if (transform.position.x < -18)
        {
            transform.position = new Vector2(12, transform.position.y);
        }


    }



}