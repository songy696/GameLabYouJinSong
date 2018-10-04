using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text timeText;
    float totalTime = 60;

    private float startTime;


    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float t = totalTime = Time.time - startTime;

        //string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timeText.text = "Time: " + seconds;

    }



    //public void Finnish(){

     //   Finnish = true;
     //   timeText.color = Color.black;
     //}

}