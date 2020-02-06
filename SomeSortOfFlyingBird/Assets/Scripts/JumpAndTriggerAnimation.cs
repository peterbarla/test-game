using UnityEngine;

public class JumpAndTriggerAnimation : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    private float JUMP_AMOUNT = 100f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetButtonDown("Space"))
        {
            animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * JUMP_AMOUNT;
    }
   
}
