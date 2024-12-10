using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jumpSpeed = 275.0f;
    private bool onGround = false;

    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float movementSpeed;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }

    
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Item"))
        {
            jumpSpeed = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Item"))
        {
            jumpSpeed = 275f;
        }
    }
    void OnCollisionStay()
    {
        onGround = true;
    }
}
