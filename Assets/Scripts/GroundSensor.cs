using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private PlayerrController controller;
    public bool isGrounded;

    void Awake ()
    {
        controller = GetComponentInParent<PlayerrController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        isGrounded = false;
    }
}