using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    Atractor planet;
    Rigidbody rb;
    private void Awake()
    {
        planet=GameObject.FindGameObjectWithTag("Planet").GetComponent<Atractor>();
        rb=GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints=RigidbodyConstraints.FreezeRotation;
        
        
    }

    private void FixedUpdate()
    {
        planet.Attract(this.gameObject);
    }
}
