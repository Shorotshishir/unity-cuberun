using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwarfForce = 1000f;
    public float sideForce = 500f;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwarfForce * Time.deltaTime, ForceMode.VelocityChange);
 
    }
}