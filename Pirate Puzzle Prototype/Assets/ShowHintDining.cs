using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Localization.Components;
using Apple.Accessibility;
using UnityEngine;

public class ShowHintDining : MonoBehaviour
{

    [SerializeField] string[] hintText;
    [SerializeField] AccessibilityNode node;


    private TMP_Text hintTMP;
    private LocalizeStringEvent locale;

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
        locale = GetComponent<LocalizeStringEvent>();
    }

    public void ShowHint(int index)
    {
        locale.SetEntry("Hint" + index);
        node.AccessibilityLabel = hintTMP.text;
        //hintTMP.text = hintText[index];
    }

}
