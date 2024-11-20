using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PlayerPrefab;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public float playerSpeed = 4.0f;
    public float jumpSpeed = 2.0f;
    public Transform groundReference;
    
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");

        Vector3 velo = Vector3.zero;

        velo += transform.forward * v;
        velo *= playerSpeed;
        velo.y = rb.velocity.y;

        {
            if (Input.GetKey(up))
            {
                transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(left))
            {
                transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(right))
            {
                transform.position += Vector3.right * playerSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(down))
            {
                transform.position += Vector3.back * playerSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {
                velo.y = jumpSpeed;
            }
            rb.velocity = velo;
        }

        bool IsGrounded()
        {
            return Physics.Raycast(groundReference.position, Vector3.down, .15f);
        }


    }
}
