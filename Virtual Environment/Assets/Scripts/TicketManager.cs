using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketManager : MonoBehaviour
{
    public bool hasTicket;
    public bool Ticket1;
    public bool Ticket2;
    public bool Ticket3;
    public bool Ticket4;
    public bool Ticket5;
    public bool Ticket6;
    public bool Ticket7;
    public bool Ticket8;

    public GameObject TicketMenu;
    public GameObject TicketCheck;
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject Screen4;
    public GameObject Screen5;
    public GameObject Screen6;
    public GameObject Screen7;
    public GameObject Screen8;

    public GameObject PlayerCam;

    public GameObject minimap;

    // Start is called before the first frame update
    void Start()
    {
        hasTicket = false;
        Ticket1 = false;
        Ticket2 = false;
        Ticket3 = false;
        Ticket4 = false;
        Ticket5 = false;
        Ticket6 = false;
        Ticket7 = false;
        Ticket8 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTicket == true)
        {
            TicketCheck.SetActive(false);
        }

        if (hasTicket == false)
        {
            TicketCheck.SetActive(true);
        }

        if(Ticket1 == true)
        {
            Screen1.SetActive(false);
        }

        if (Ticket2 == true)
        {
            Screen2.SetActive(false);
        }

        if (Ticket3 == true)
        {
            Screen3.SetActive(false);
        }

        if (Ticket4 == true)
        {
            Screen4.SetActive(false);
        }

        if (Ticket5 == true)
        {
            Screen5.SetActive(false);
        }

        if (Ticket6 == true)
        {
            Screen6.SetActive(false);
        }

        if (Ticket7 == true)
        {
            Screen7.SetActive(false);
        }

        if (Ticket8 == true)
        {
            Screen8.SetActive(false);
        }

        if (Ticket1 == false)
        {
            Screen1.SetActive(true);
        }

        if (Ticket2 == false)
        {
            Screen2.SetActive(true);
        }

        if (Ticket3 == false)
        {
            Screen3.SetActive(true);
        }

        if (Ticket4 == false)
        {
            Screen4.SetActive(true);
        }

        if (Ticket5 == false)
        {
            Screen5.SetActive(true);
        }

        if (Ticket6 == false)
        {
            Screen6.SetActive(true);
        }

        if (Ticket7 == false)
        {
            Screen7.SetActive(true);
        }

        if (Ticket8 == false)
        {
            Screen8.SetActive(true);
        }
    }

    public void Select1()
    {
        hasTicket = true;
        Ticket1 = true;
    }

    public void Select2()
    {
        hasTicket = true;
        Ticket2 = true;
    }

    public void Select3()
    {
        hasTicket = true;
        Ticket3 = true;
    }

    public void Select4()
    {
        hasTicket = true;
        Ticket4 = true;
    }

    public void Select5()
    {
        hasTicket = true;
        Ticket5 = true;
    }

    public void Select6()
    {
        hasTicket = true;
        Ticket6 = true;
    }

    public void Select7()
    {
        hasTicket = true;
        Ticket7 = true;
    }

    public void Select8()
    {
        hasTicket = true;
        Ticket8 = true;
    }

    public void Confirm()
    {
        TicketMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerCam.SetActive(true);
        minimap.SetActive(true);
    }

    void OnTriggerEnter(Collider collsion)
    {
        Debug.Log("In");
        hasTicket = false;
        Ticket1 = false;
        Ticket2 = false;
        Ticket3 = false;
        Ticket4 = false;
        Ticket5 = false;
        Ticket6 = false;
        Ticket7 = false;
        Ticket8 = false;
    }
}
