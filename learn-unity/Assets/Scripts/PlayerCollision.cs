using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.gameObject.CompareTag("Walls")) {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

