using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoActive : MonoBehaviour
{
    public GameObject video;

    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("In Screen 1");
            video.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            video.SetActive(false);
        }
    }
}
