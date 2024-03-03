using System.Collections;
using System.Collections.Generic;
using EasyTransition;
using UnityEngine;

public class TransitionNavigation : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] TransitionSettings transition;
    [SerializeField] float loadDelay = 0f;


    public void NavigateTo()
    {
        TransitionManager.Instance().Transition(sceneName,transition,loadDelay);
    }
}
