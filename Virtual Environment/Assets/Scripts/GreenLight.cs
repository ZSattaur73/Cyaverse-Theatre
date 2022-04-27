using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLight : MonoBehaviour
{
    public GameObject greenlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Light");
    }

    IEnumerator Light()
    {
        float emissiveIntensity = 1000000f;
        float off = 1f;
        Color emissiveColor = Color.white;
        greenlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
        yield return new WaitForSeconds(5f);
        greenlight.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * off);
        yield return new WaitForSeconds(10f);
    }
}
