using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(-10f, 0, 0);
    }
}
