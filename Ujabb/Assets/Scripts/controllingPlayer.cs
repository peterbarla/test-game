using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isLeft = false;
    private bool isRight = false;
    public Rigidbody rb;

    public float sideSpeed;
    private bool isEnd = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        isLeft = false;
        isRight = false;


        if (Input.GetKey("d"))
        {
            isRight = true;
            
        }
 

        if (Input.GetKey("a"))
        {
            isLeft = true;
            
        }
  

        if (isLeft)
        {
            //this.transform.Translate(-5 * Time.deltaTime,0,0);
           // Debug.Log("na");
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (isRight)
        {
           // this.transform.Translate(5 * Time.deltaTime, 0, 0);
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }

        if (this.transform.position.y < 0.5f)
        {
            if (!isEnd)
            {
                isEnd = true;
                FindObjectOfType<manageGame>().endGame();
            }
        }


    }
}
