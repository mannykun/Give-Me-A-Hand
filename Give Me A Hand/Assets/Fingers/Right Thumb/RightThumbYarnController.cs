using UnityEngine;
using Yarn.Unity;

public class RightThumbYarnController : MonoBehaviour
{
    public Animator animator;

    [YarnCommand("PlayIdle")]
    public void PlayIdle()
    {
        animator.Play("RT Idle00");
    }

    [YarnCommand("PlayHappy")]
    public void PlayHappy()
    {
        animator.Play("RT Happy00"); 
    }

    [YarnCommand("PlayCrazy")]
    public void PlayCrazy()
    {
        animator.Play("CrazyAnim");
    }
}