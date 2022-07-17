using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
    private bool _isOscillating = false;
    private bool _isGreen = false;
    private Rigidbody rb;
    private Renderer _renderer;
    [SerializeField]
    private Material _red;
    [SerializeField]
    private Material _green;

    Vector3 startingPos;
    [SerializeField] Vector3 movementVector = Vector3.right * 2;
    float movementFactor;
    [SerializeField] float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("The Rigidbody is NULL.");
        }
        else
        {
            rb.useGravity = false;
        }
        _renderer = GetComponent<Renderer>();
        if (_renderer == null)
        {
            Debug.LogError("The Renderer is NULL.");
        }
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isOscillating == true)
        {
            if (period <= Mathf.Epsilon)
            {
                return;
            }
            float cycles = Time.time / period;
            const float tau = Mathf.PI * 2;
            float rawSineWave = Mathf.Sin(cycles * tau);
            movementFactor = (rawSineWave + 1f) / 2f;
            Vector3 offset = movementVector * movementFactor;
            transform.position = startingPos + offset;
        }
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
    public void isOscillating()
    {
        _isOscillating = true;
    }
    public void isGreen()
    {
        _isGreen = true;
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (_isGreen == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("YOU MADE IT");
            }
        }
    }
}
