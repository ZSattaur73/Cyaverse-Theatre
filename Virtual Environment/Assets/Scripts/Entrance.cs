using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    public GameObject enter;
    public GameObject enjoy;

    private TicketManager tm;

    // Start is called before the first frame update
    void Start()
    {
        enter.SetActive(false);
        enjoy.SetActive(false);
        tm = GameObject.Find("TheatreManager").GetComponent<TicketManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player" && tm.hasTicket == false)
        {
            enter.SetActive(true);
            enjoy.SetActive(false);
        }

        if (collision.gameObject.tag == "Player" && tm.hasTicket == true)
        {
            enter.SetActive(false);
            enjoy.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enter.SetActive(false);
            enjoy.SetActive(false);
        }
    }
}
