﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    private Vector3 offSet = new Vector3(0, 0, -2);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offSet;
    }
}
