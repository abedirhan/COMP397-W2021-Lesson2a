using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;

    public Rigidbody rigidbody;
    // public CharacterController controller;

    // public float maxSpeed = 10.0f;
    // public float gravity = -30.0f;
    // public float jumpHeight = 3.0f;
    //
    // public Transform groundCheck;
    // public float groundRadius = 0.5f;
    // public LayerMask groundMask;
    //
    // public Vector3 velocity;
    // public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame - once every 16.6666ms

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal")>0)
        {
            //Move right
           rigidbody.AddForce(Vector3.right*movementForce);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //Move left
            rigidbody.AddForce(Vector3.left * movementForce);


        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //Move forward
            rigidbody.AddForce(Vector3.forward * movementForce);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //Move back
            rigidbody.AddForce(Vector3.back * movementForce);
        }

        // isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundMask);
        //
        // if (isGrounded && velocity.y < 0)
        // {
        //     velocity.y = -2.0f;
        // }
        //
        // float x = Input.GetAxis("Horizontal");
        // float z = Input.GetAxis("Vertical");
        //
        // Vector3 move = transform.right * x + transform.forward * z;
        //
        // controller.Move(move * maxSpeed * Time.deltaTime);
        //
        // if (Input.GetButton("Jump") && isGrounded)
        // {
        //     velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
        // }
        //
        // velocity.y += gravity * Time.deltaTime;
        //
        // controller.Move(velocity * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        // Gizmos.color = Color.white;
        // Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
    }

}
