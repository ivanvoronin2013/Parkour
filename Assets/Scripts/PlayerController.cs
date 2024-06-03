using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        rb.velocity = transform.forward * Time.deltaTime* speed;
    }
}
