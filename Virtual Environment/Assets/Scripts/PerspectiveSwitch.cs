using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspectiveSwitch : MonoBehaviour
{

    public GameObject TPCam;
    public GameObject FPCam;
    public CharacterController player;
    public GameObject Screen1Cam;
    public GameObject Screen2Cam;
    public GameObject Screen3Cam;
    public GameObject Screen4Cam;
    public GameObject Screen5Cam;
    public GameObject Screen6Cam;
    public GameObject Screen7Cam;
    public GameObject Screen8Cam;

    public GameObject minimap;
    public GameObject mapcam;
    public GameObject poi;

    //public GameObject ticketCam;

    //public GameObject Screen1;
    //public GameObject Screen2;
    //public GameObject Screen3;
    //public GameObject Screen4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("1"))
        {
            TPCam.SetActive(true);
            FPCam.SetActive(false);
            //player.SetActive(true);
            Screen1Cam.SetActive(false);
            Screen2Cam.SetActive(false);
            Screen3Cam.SetActive(false);
            Screen4Cam.SetActive(false);
            Screen5Cam.SetActive(false);
            Screen6Cam.SetActive(false);
            Screen7Cam.SetActive(false);
            Screen8Cam.SetActive(false);
            minimap.SetActive(true);
            mapcam.SetActive(false);
            //ticketCam.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            poi.SetActive(false);
        }
        
        if (Input.GetKey("2"))
        {
            FPCam.SetActive(true);
            TPCam.SetActive(false);
            //player.SetActive(true);
            Screen1Cam.SetActive(false);
            Screen2Cam.SetActive(false);
            Screen3Cam.SetActive(false);
            Screen4Cam.SetActive(false);
            Screen5Cam.SetActive(false);
            Screen6Cam.SetActive(false);
            Screen7Cam.SetActive(false);
            Screen8Cam.SetActive(false);
            minimap.SetActive(true);
            mapcam.SetActive(false);
            //ticketCam.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            poi.SetActive(false);
        }

        if (Input.GetKey("m"))
        {
            FPCam.SetActive(false);
            TPCam.SetActive(false);
            //player.SetActive(true);
            Screen1Cam.SetActive(false);
            Screen2Cam.SetActive(false);
            Screen3Cam.SetActive(false);
            Screen4Cam.SetActive(false);
            Screen5Cam.SetActive(false);
            Screen6Cam.SetActive(false);
            Screen7Cam.SetActive(false);
            Screen8Cam.SetActive(false);
            minimap.SetActive(false);
            mapcam.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            poi.SetActive(true);
        }

    }
}
