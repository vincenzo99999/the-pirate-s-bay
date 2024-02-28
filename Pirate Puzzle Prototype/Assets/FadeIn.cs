using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void FadeInTrigger()
    {
        animator.SetTrigger("Clicked");
    }
}
