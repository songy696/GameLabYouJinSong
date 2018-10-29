using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

    //bool gameHasEnded = false;

    //public void EndGame(){
    //    if (gameHasEnded == false)
    //    {
    //        gameHasEnded = true;
    //        Restart();
    //    }
    //}

    //void Restart (){
    //    SceneManager.LoadScene("SampleScene");
    //}

    public void LoadScene(string sceneName)
    {         SceneManager.LoadScene("SampleScene");     } 
}
