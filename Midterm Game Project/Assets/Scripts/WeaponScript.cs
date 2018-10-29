using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{

    //public weaponDamage = 1;
    public GameObject bladeTrailPrefab;
    public float minCuttingVelocity = .001f;

    bool isCutting = false;

    Vector2 previousPosition;

    GameObject currentBladeTrail;

    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;

    public int damageToGive;

    public Text countText;

    private int count;

    public Text winText;


    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();

        count = 0;
        SetCountText();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
            //Enemy health = currentHealth.collider.GetComponent;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateCut();
        }

    }

    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }

        previousPosition = newPosition;
    }

    void StartCutting()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = newPosition;
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().HurtEnemy(damageToGive);
            count = count + 1;
            SetCountText();
        }

       
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 30)
        {
            winText.text = "SLEPT WELL!";
        }
    }



    void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 0.01f);
        circleCollider.enabled = false;
    }

}