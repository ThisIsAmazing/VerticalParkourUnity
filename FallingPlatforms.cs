using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.tag == "Layer 0") && (Time.time > 2f))
        {
            rb.useGravity = true;

        }
        else if ((gameObject.tag == "Layer 1") && (Time.time > 4f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 2") && (Time.time > 6f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 3") && (Time.time > 8f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 4") && (Time.time > 10f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 5") && (Time.time > 12f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 6") && (Time.time > 14f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 7") && (Time.time > 16f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 8") && (Time.time > 18f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 9") && (Time.time > 20f))
        {
            rb.useGravity = true;
        }
        else if ((gameObject.tag == "Layer 10") && (Time.time > 22f))
        {
            rb.useGravity = true;
        }






        

    }
}
