using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changevalues : MonoBehaviour {

    void OnGUI()
    {
        if(GUI.Button(new Rect(10, 100, 100, 30), "Health up")) {
            gameControl.control.health += 5;
        }

        if (GUI.Button(new Rect(10, 140, 100, 30), "Health down"))
        {
            gameControl.control.health -= 5;
        }

        if (GUI.Button(new Rect(10, 180, 100, 30), "Money up"))
        {
            gameControl.control.money += 5;
        }

        if (GUI.Button(new Rect(10, 220, 100, 30), "Money down"))
        {
            gameControl.control.money -= 5;
        }
    }

}
