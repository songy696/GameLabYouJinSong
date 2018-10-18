using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public UnityEngine.UI.Text goldDisplay;
    public int gold = 0;
    public int goldperclick = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
	}

    public void Clicked(){

        gold += goldperclick;



    
    }
}
