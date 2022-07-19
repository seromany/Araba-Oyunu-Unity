using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal")*5;
        yatay *= Time.deltaTime;
        rb.AddForce(Vector3.forward * 5);
        transform.Translate(yatay,0,0);
    }
}
