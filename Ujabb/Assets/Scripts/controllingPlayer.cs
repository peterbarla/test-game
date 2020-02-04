using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isLeft = false;
    private bool isRight = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            this.transform.Translate(-5 * Time.deltaTime,0,0);
        }


        if (isRight)
        {
            this.transform.Translate(5 * Time.deltaTime, 0, 0);
        }
    }
}
