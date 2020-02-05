using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;
    private bool once = false;
    void Update()
    {
        
        if (Input.GetButtonDown("Space"))
        {
            animator.Play("WhenPressedSpaceMoveNoseUpAnimation");
        }
    }
   
}
