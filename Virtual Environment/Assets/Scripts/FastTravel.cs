using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTravel : MonoBehaviour
{
    public bool theatre;
    public bool mall;
    public bool downtown;
    public bool park;

    public GameObject theatretravel;
    public GameObject malltravel;
    public GameObject downtowntravel;
    public GameObject parktravel;

    //public GameObject player;

    PlayerMove player;

    public GameObject Map;
    public GameObject poi;
    public GameObject playerCam;
    public GameObject minimap;

    // Start is called before the first frame update
    void Start()
    {
        theatre = false;
        mall = false;
        downtown = false;
        park = false;

        player = gameObject.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theatre == true && Input.GetKey("f"))
        {
            StartCoroutine("TheatreTravel");
        }

        if(mall == true && Input.GetKey("f"))
        {
            StartCoroutine("MallTravel");
        }

        if (downtown == true && Input.GetKey("f"))
        {
            StartCoroutine("DowntownTravel");
        }

        if (park == true && Input.GetKey("f"))
        {
            StartCoroutine("ParkTravel");
        }
    }

    IEnumerator TheatreTravel()
    {
        Debug.Log("travel");
        player.disabled = true;
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(theatretravel.transform.position.x, theatretravel.transform.position.y, theatretravel.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        player.disabled = false;
        Map.SetActive(false);
        poi.SetActive(false);
        playerCam.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        theatre = false;
        minimap.SetActive(true);
    }

    IEnumerator MallTravel()
    {
        Debug.Log("travel");
        player.disabled = true;
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(malltravel.transform.position.x, malltravel.transform.position.y, malltravel.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        player.disabled = false;
        Map.SetActive(false);
        poi.SetActive(false);
        playerCam.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mall = false;
        minimap.SetActive(true);
    }

    IEnumerator DowntownTravel()
    {
        Debug.Log("travel");
        player.disabled = true;
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(downtowntravel.transform.position.x, downtowntravel.transform.position.y, downtowntravel.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        player.disabled = false;
        Map.SetActive(false);
        poi.SetActive(false);
        playerCam.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        downtown = false;
        minimap.SetActive(true);
    }

    IEnumerator ParkTravel()
    {
        Debug.Log("travel");
        player.disabled = true;
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(parktravel.transform.position.x, parktravel.transform.position.y, parktravel.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        player.disabled = false;
        Map.SetActive(false);
        poi.SetActive(false);
        playerCam.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        park = false;
        minimap.SetActive(true);
    }

    public void TheatrePoint()
    {
        theatre = true;
        mall = false;
        downtown = false;
        park = false;
    }

    public void MallPoint()
    {
        theatre = false;
        mall = true;
        downtown = false;
        park = false;
    }

    public void DowntownPoint()
    {
        theatre = false;
        mall = false;
        downtown = true;
        park = false;
    }

    public void ParkPoint()
    {
        theatre = false;
        mall = false;
        downtown = false;
        park = true;
    }
}
