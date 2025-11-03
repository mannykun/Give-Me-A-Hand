using UnityEngine;

public class RightThumbAnimationController : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation(string animationName)
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
    }
}