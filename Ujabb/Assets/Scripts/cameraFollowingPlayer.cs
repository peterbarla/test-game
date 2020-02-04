using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transformPlayer;
    private Vector3 distanceVector;
    void Start()
    {
        distanceVector = new Vector3(0, 1, -5);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = transformPlayer.position + distanceVector;
    }
}
