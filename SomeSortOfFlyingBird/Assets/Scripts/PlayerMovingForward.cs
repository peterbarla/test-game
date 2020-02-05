using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingForward : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 vector = new Vector2(1 , 0);
    void FixedUpdate()
    {
        rb.AddForce(vector);
    }
}
