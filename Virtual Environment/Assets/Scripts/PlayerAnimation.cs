using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (z > 0.1f)
        {
            anim.SetBool("isWalking", true);
        }

        if (z < -0.1f)
        {
            anim.SetBool("WalkingBack", true);
        }

        if (z > -0.1f && z < 0.1f)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("WalkingBack", false);
        }
    }
}
