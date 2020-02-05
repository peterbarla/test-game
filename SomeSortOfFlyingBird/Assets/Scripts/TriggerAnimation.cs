using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    private Vector2 vector= new Vector2(0,5);
    void Update()
    {

        if (Input.GetButtonDown("Space"))
        {
            animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
            rb.AddForce(vector,ForceMode2D.Impulse);
        }
    }
   
}
