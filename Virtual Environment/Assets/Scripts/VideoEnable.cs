using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEnable : MonoBehaviour
{
    public GameObject video1;
    public GameObject video2;
    public GameObject video3;
    public GameObject video4;
    public GameObject video5;
    public GameObject video6;
    public GameObject video7;
    public GameObject video8;
    public string onButton1;
    public string onButton2;
    public string onButton3;
    public string onButton4;
    public string onButton5;
    public string onButton6;
    public string onButton7;
    public string onButton8;
    public string offButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(onButton1))
        {
            video1.SetActive(true);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton2))
        {
            video1.SetActive(false);
            video2.SetActive(true);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton3))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(true);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton4))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(true);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton5))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(true);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton6))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(true);
            video7.SetActive(false);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton7))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(true);
            video8.SetActive(false);
        }
        if (Input.GetKeyDown(onButton8))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(true);
        }

        if (Input.GetKeyDown(offButton))
        {
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(false);
            video4.SetActive(false);
            video5.SetActive(false);
            video6.SetActive(false);
            video7.SetActive(false);
            video8.SetActive(false);
        }

    }
}
