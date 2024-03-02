using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject tap;
    
    public void FadeInTrigger()
    {
        animator.gameObject.SetActive(true);
        animator.SetTrigger("Clicked");
        tap.SetActive(false);
    }
}
