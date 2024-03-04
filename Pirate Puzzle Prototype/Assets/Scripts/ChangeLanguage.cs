using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{

    [SerializeField] string[] languages;
    [SerializeField] TextMeshProUGUI languageButtonText;
    [SerializeField] LocalisationManager localisationManager;

    [SerializeField] Animator wipAnim;
    [SerializeField] LocaleSelector localeSelector;

    private int languageIndex = 0;


    public void SwitchLanguage()
    {

        wipAnim.SetTrigger("buttonPressed");

        if(languageIndex < languages.Length -1)
            languageIndex++;
        else
            languageIndex = 0;

        localeSelector.ChangeLocale(languageIndex);

        //languageButtonText.text = languages[languageIndex];

        //localisationManager.SetLocalisation(languageIndex);
    }
}
