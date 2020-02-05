using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionWithObstacles : MonoBehaviour
{
    // Start is called before the first frame update

    public moveForwardUsingThis movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<manageGame>().endGame();
        }
    }
}
