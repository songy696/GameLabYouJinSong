using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SleeperHealthManager : MonoBehaviour {

    //   public int playerCurrentHealth;
    //   public int playerMaxHealth;

      public Text winText;     public GameObject gameOverText, restartButton;   


    //// Use this for initialization
    void Start () {
        //playerCurrentHealth = playerMaxHealth;
        gameOverText.SetActive(false);         restartButton.SetActive(false);          winText.text = "";


    }

    //// Update is called once per frame
    void Update () {
        //if(FindObjectOfType<Enemy>().CurrentHealth <=0){
        //    gameObject.SetActive(false);
        //    count = count + 1;
        //    SetCountText();
        //}

    }

    void OnTriggerEnter2D(Collider2D other)     {

        if(other.gameObject.CompareTag("Enemy")){
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
          

        }

     

    }
 

    //public void HurtSleeper(int damageToGive){
    //    playerCurrentHealth -= damageToGive;
    //}

    //public void SetMaxHealth(){
    //    playerCurrentHealth = playerMaxHealth;
    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{

    //    if (other.gameObject.CompareTag("Enemy"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
