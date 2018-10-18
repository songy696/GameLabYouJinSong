using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBackgrounds : MonoBehaviour
{


    public Vector2 speed = new Vector2(1,1);
    public Vector2 direction = new Vector2(1, 0);
    public bool isLinkedToCamera = false;


    void Update(){


        Vector3 movement = new Vector3(speed.x/5 * -direction.x, speed.y/5 * direction.y, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (isLinkedToCamera)
        {
            Camera.main.transform.Translate(movement);
        }
    }

}