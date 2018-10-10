using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private float totalTime = 60f;
    public string levelToLoad;
    Text text;
    private Text startTime;


    // Use this for initialization
    void Start()
    {
        startTime = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {

        totalTime -= Time.deltaTime;
        startTime.text = totalTime.ToString("f2");
        if (totalTime <= 0)
        {
            SceneManager.GetSceneByName("manu");
        }

    }


}
