using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheatreExit : MonoBehaviour
{
    public GameObject minimap;

    // Start is called before the first frame update
    void Start()
    {
        minimap.SetActive(true);
    }
}
