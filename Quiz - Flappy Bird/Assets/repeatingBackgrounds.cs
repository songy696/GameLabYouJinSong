using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBackgrounds : MonoBehaviour
{
    //private Transform cameraTransform;
    //private float spriteWidth;

    //private BoxCollider2D groundCollider;
    //private float groundHorizontalLength;

    public float speed = -1f;
    Vector3 startPosition;

    //public Renderer rend;

    void Start ()
    {
        //cameraTransform = Camera.main.transform;
        //SpriteRenderder spriteRenderder = renderer as SpriteRenderer;
        //spriteWidth = spriteRenderder.sprite.bounds.size.x;

        //groundCollider = GetComponent<BoxCollider2D>();
        //groundHorizontalLength = groundCollider.size.x;

        //rb2d = GetComponent<Rigidbody2D>();
        //rb2d.velocity = new Vector2(Time.deltaTime * speed, 0);

        startPosition = transform.position;

    }

    void Update(){

        //Vector3 moveDirection 
        transform.Translate((new Vector3(1, 0, 0)) * speed * Time.deltaTime); 

        //if((cameraTransform.position.x + spriteWidth) < cameraTransform.position.x){
        //    Vector3 newPos = transform.position;
        //    newPos.x += 2.0f * spriteWidth;
        //    transform.position = newPos;
        //}

        if (transform.position.x < - 20){
            transform.position = startPosition;
        }

        //Vector2 offset = new Vector2(Time.deltaTime * speed, 0);
        //rend.material.mainTextureOffset = offset;

        //float offset = Time.deltaTime * speed;
        //rend.material.mainTextureOffset = new Vector2 (offset, 0);

    }


    //private void RepositionBackground() 
    //{
    //    Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
    //    transform.position = (Vector2)transform.position + groundOffset;

    //}

}