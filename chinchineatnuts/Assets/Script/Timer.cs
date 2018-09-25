using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text timeText;
    float totalTime = 60;

    //private float startTime;


    // Use this for initialization
    void Start()
    {
        //startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        //float t = totalTime;
        totalTime -= Time.deltaTime;

        //float t = Time.time - startTime;

        //string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString("f2");

        //timeText.text = minutes + ";" + seconds;

    }

    private void OnGUI()
    {
        if (totalTime > 0)
        {
            GUI.Label(new Rect(550, 180, 500, 500), "Time Remaining : " + (int)totalTime);
        }
        else
        {
            GUI.Label(new Rect(550, 180, 500, 500), "Time's up");
        }
    }


    //public void Finnish(){

    ////        //finnished = true;
     //   timeText.color = Color.black;
     //}

}