using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePlatforms : MonoBehaviour
{

    public GameObject platform;
    //GameObject clone;
    float timer = 0;

    //tagging all the variables, grouping
    GameObject[] platforms;


    void Start()
    {
        //clone = Instantiate(platform, (new Vector2(Random.Range(-8f, 8f), 6f)), Quaternion.identity);
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1){
            GameObject clone = Instantiate(platform, (new Vector2(Random.Range(-8f, 8f), 6f)), Quaternion.identity);
            platform.transform.localScale = new Vector3(Random.Range(2f, 8f), 1f);
            timer = 0;
        }

        platforms = GameObject.FindGameObjectsWithTag("platform");

        foreach(GameObject platform in platforms) {
            platform.transform.localPosition = new Vector2(platform.transform.localPosition.x, platform.transform.localPosition.y - 0.05f);

            if (platform.transform.localPosition.y < -9){
                Destroy (platform);
            }
        }
        
    }
}
