using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderTimer : MonoBehaviour {

    public float healthRemaining;
    public Slider slider;
    private const float timerMax = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        slider.value = CalculateSliderValue();

        if (Input.GetKeyDown(KeyCode.Space)){

            healthRemaining = healthRemaining + 0.1f;
        }

        if (healthRemaining <=0){

            healthRemaining = 0;

        }else if (healthRemaining > 0) {

            healthRemaining -= Time.deltaTime;
        }
	}

    float CalculateSliderValue(){

        return (healthRemaining / timerMax);
    }

}
