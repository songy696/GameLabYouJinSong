using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeAction : MonoBehaviour {

    public Slider slidey;
    public Text winText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        //change UI
        float value = slidey.value;
        slidey.value = value + 1;

        //change wintext
        if (value <= 1){
            winText.text = "" ;
        } else if (slidey.value == 5) {
            winText.text = "You Win!";
        }

        Destroy(this.gameObject); // this is to remove the game object when you click on it.
    }
}
