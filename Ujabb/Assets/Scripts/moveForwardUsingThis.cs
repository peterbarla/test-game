using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForwardUsingThis : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform transform;
    public Rigidbody rb;
    public float forwardSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // this.t.Translate(0,0, 10 * Time.deltaTime);
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime,ForceMode.VelocityChange);
    }
}
