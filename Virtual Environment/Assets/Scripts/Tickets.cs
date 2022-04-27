using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tickets : MonoBehaviour
{
    public GameObject TicketMenu;

    public GameObject ticketCam;
    public GameObject TPCam;
    public GameObject FPCam;
    public GameObject TicketInstructions;
    public GameObject minimap;

    private TicketManager tm;

    // Start is called before the first frame update
    void Start()
    {
        TicketMenu.SetActive(false);
        TicketInstructions.SetActive(false);
        tm = GameObject.Find("TheatreManager").GetComponent<TicketManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("At Counter");
        }

        if (Input.GetButton("Jump"))
        {
            TicketMenu.SetActive(true);
            TicketInstructions.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ticketCam.SetActive(true);
            TPCam.SetActive(false);
            FPCam.SetActive(false);
            tm.hasTicket = false;
            tm.Ticket1 = false;
            tm.Ticket2 = false;
            tm.Ticket3 = false;
            tm.Ticket4 = false;
            tm.Ticket5 = false;
            tm.Ticket6 = false;
            tm.Ticket7 = false;
            tm.Ticket8 = false;
            minimap.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        TicketInstructions.SetActive(true);
    }

    void OnTriggerExit(Collider collision)
    {
        TicketInstructions.SetActive(false);
    }
}
