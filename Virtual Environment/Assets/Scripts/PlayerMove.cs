using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController character;
    public float speed = 72f;
    public float gravity = 1000f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jump = 3f;

    Vector3 velocity;
    bool isGrounded;

    public bool disabled = false;

    // Update is called once per frame
    void Update()
    {
        if (!disabled)
        {
            Move();
        }
    }

    void Move()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z;

        character.Move(move * speed * Time.deltaTime);

        if(Input.GetAxis("Vertical") > 0.1f && Input.GetAxis("Fire1") > 0.1f)
        {
            Debug.Log("run");
        }

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        //}

        velocity.y -= gravity * Time.deltaTime;

        character.Move(velocity * Time.deltaTime);
    }
}
