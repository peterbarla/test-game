using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreIncreaser : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;
    public Text text;
    private string startingText;

    void Start()
    {

        startingText = text.text;
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = startingText + transform.position.z.ToString("0");
    }
}
