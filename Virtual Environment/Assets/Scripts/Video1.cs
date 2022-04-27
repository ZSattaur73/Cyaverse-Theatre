using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video1 : MonoBehaviour
{
    public VideoPlayer video;
    private string filePath;
    public string videoName;

    // Start is called before the first frame update
    void OnEnable()
    {
        filePath = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
        video.url = filePath;
        Debug.Log(video.url);
        video.Play();
    }

}
