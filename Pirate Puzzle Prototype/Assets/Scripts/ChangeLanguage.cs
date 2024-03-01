using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    [SerializeField] string[] languages;
    [SerializeField] TextMeshProUGUI languageButtonText;
    [SerializeField] LocalisationManager localisationManager;

    private int languageIndex = 0;

    public void SwitchLanguage()
    {

        if(languageIndex < languages.Length -1)
            languageIndex++;
        else
            languageIndex = 0;

        languageButtonText.text = languages[languageIndex];

        localisationManager.SetLocalisation(languageIndex);
    }
}
