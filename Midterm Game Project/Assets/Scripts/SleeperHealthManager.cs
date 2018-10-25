using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleeperHealthManager : MonoBehaviour {

    public int playerCurrentHealth;
    public int playerMaxHealth;

	// Use this for initialization
	void Start () {
        playerCurrentHealth = playerMaxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(playerCurrentHealth <=0){
            gameObject.SetActive(false);
        }
		
	}

    public void HurtSleeper(int damageToGive){
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth(){
        playerCurrentHealth = playerMaxHealth;
    }
}
