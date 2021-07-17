using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public bool isGrounded;
    public int forwardForce = 1000;
    public int sidewaysForce = 500;

    void OnCollisionStay() {
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && isGrounded) 
        {
            rb.AddForce(0, 7000 * Time.deltaTime, 0);
            isGrounded = false;
        }

        if (rb.position.y < -1) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
