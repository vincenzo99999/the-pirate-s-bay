using System.Collections;
using System.Collections.Generic;
using TMPro;
using Apple.Accessibility;
using EasyTransition;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] string[] textLines;

    [SerializeField] string sceneName;
    [SerializeField] TransitionSettings transition;
    [SerializeField] float loadTime = 0f;

    

    private int index = 0;
    private TMP_Text tmp;
    private AccessibilityNode node;
    private LocalizeStringEvent locale;

    private void Awake()
    {
        node = GetComponent<AccessibilityNode>();
        tmp = GetComponent<TMP_Text>();
        locale = GetComponent<LocalizeStringEvent>();

        /*
        node.AccessibilityValue = textLines[index];
        tmp.text = textLines[index++];
        */

        

    }

    public void ShowNextLine()
    {
        if (index < textLines.Length -1)
        {
            locale.SetEntry("Dialogue" + (index+++1) + " Intro");

        }
        else
        {
            TransitionManager.Instance().Transition(sceneName, transition, loadTime);
        }

        
    }

}
