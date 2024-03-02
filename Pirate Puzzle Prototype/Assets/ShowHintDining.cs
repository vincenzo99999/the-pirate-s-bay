using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowHintDining : MonoBehaviour
{

    [SerializeField] string[] hintText;

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
        hintTMP = GetComponent<TMP_Text>();
    }

    public void ShowHint(int index)
    {
        hintTMP.text = hintText[index];
    }

}
