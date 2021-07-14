using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public int forwardForce = 1000;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a")) 
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d")) 
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
    }
}
