using System.Collections;
using System.Collections.Generic;
using TMPro;
using Apple.Accessibility;
using UnityEngine;

public class ShowHintDining : MonoBehaviour
{

    [SerializeField] string[] hintText;
    [SerializeField] AccessibilityNode node;


    private TMP_Text hintTMP;

    enum Hints
    {
        Eyepatch,
        Trinket,
        Bottles,
        Letter
    }

    private void Start()
    {
        node = GetComponent<AccessibilityNode>();
        hintTMP = GetComponent<TMP_Text>();
    }

    public void ShowHint(int index)
    {
        node.AccessibilityLabel = hintText[index];
        hintTMP.text = hintText[index];
    }

}
