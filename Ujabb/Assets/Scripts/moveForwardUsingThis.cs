using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForwardUsingThis : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform transform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(1 * Time.deltaTime,0,0);
    }
}
