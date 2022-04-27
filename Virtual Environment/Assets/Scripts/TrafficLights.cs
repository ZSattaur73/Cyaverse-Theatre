using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    public GameObject greenlight;
    public GameObject yellowlight;
    public GameObject redlight;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("LightChange");
    }

    IEnumerator LightChange()
    {
        float emissiveIntensity = 1000000;
        Color emissiveColor = Color.white;
        greenlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
        redlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        yellowlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        yield return new WaitForSeconds(5f);
        //Color emissiveColor = Color.red;
        greenlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        redlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
        yellowlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        yield return new WaitForSeconds(5f);
        //Color emissiveColor = Color.yellow;
        greenlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        redlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor);
        yellowlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
    }
}
