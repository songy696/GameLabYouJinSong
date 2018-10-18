using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raycastShooting : MonoBehaviour {

    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;


    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private LineRenderer laserLine;
    private float nextFire;


    public Text countText;
    public Text winText;
    public GameObject gameOverText, restartButton;
    private int count;





    void Start () {
        laserLine = GetComponent<LineRenderer>();
        fpsCam = GetComponentInParent<Camera>();

        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        count = 0;
        SetCountText();
        winText.text = "";
    }
	

	void Update () 
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            StartCoroutine(ShotEffect());

            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            if (Physics.Raycast(rayOrigin,fpsCam.transform.forward, out hit, weaponRange)){

                Debug.Log(hit.point);
                laserLine.SetPosition(1, hit.point);

                shootableMonster health = hit.collider.GetComponent<shootableMonster>();
          
                if (hit.collider.name == "Cube"){

                    transform.position = hit.point;
                }
     
                

                if (health != null){

                    health.Damage(gunDamage);
                    if(health.currentHealth <=0 )
                    {
                        count = count + 1;
                        SetCountText();
                    }
                }
                if (hit.rigidbody != null){

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

            } else{
                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            }

        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("what is going on?");
            //Restart
            SceneManager.LoadScene("shootingGame");
        }
	}
    private IEnumerator ShotEffect(){

        laserLine.enabled = true;
        yield return shotDuration;
       laserLine.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monsters"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 9)
        {
            winText.text = "You Win!";
        }
    }
}
