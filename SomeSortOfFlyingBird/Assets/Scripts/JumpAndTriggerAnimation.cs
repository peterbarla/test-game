using UnityEngine;

public class JumpAndTriggerAnimation : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    private float JUMP_AMOUNT = 100f;
    private bool isAndroid = false;
    private bool isIOS = false;

    private void Awake()
    {
        #if UNITY_ANDROID
                isAndroid = true;
                isIOS = false;
        #endif

        #if UNITY_IOS
                isAndroid = false;
                isIOS = true;
        #endif
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isAndroid)
        {
            if(Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                { 
                    animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
                    Jump();
                }
            }
        }
        else if (isIOS)
        {
            if (Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
                    Jump();
                }
            }
        }
        else
        {
            if (Input.GetButtonDown("Space"))
            {
                animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
                Jump();
            }
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * JUMP_AMOUNT;
    }
   
}
