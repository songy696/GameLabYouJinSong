using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerdeath : MonoBehaviour {
    
    public Text countText;     public Text winText;
    public GameObject gameOverText, restartButton;
    private int count;

    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        count = 0;
        SetCountText();         winText.text = "";

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monsters")){
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText()     {         countText.text = "Count: " + count.ToString();         if (count >= 9)         {             winText.text = "You Win!";         }     }
}
