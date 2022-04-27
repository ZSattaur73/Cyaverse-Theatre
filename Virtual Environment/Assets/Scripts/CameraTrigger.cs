using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject TPCam;
    public GameObject FPCam;
    public GameObject ScreenCam;
    public CharacterController player;
    public GameObject minimap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collision)
    {
        //Debug.Log("Seated");

        if (collision.gameObject.tag == "Player" && Input.GetButton("Jump"))
        {
            FPCam.SetActive(false);
            TPCam.SetActive(false);
            //player.SetActive(false);
            ScreenCam.SetActive(true);
            minimap.SetActive(false);
        }
    }
}
