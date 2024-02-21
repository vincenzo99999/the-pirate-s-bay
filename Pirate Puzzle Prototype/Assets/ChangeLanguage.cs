using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    [SerializeField] string[] languages;
    [SerializeField] TextMeshProUGUI languageButtonText;


    private int languageIndex = 0;

    public void SwitchLanguage()
    {

        Debug.Log(languages.Length);

        if(languageIndex < languages.Length -1)
            languageIndex++;
        else
            languageIndex = 0;

        Debug.Log("index is at: " + languageIndex);

        languageButtonText.text = languages[languageIndex];
    }
}
