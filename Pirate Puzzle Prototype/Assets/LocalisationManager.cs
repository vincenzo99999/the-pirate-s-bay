using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LocalisationManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI resetGameButton;
    [SerializeField] TextMeshProUGUI changeLanguageText;
    [SerializeField] TextMeshProUGUI aboutButton;
    [SerializeField] TextMeshProUGUI exit;
    //Make a line like this for every string in the Strings Script

    [SerializeField] Strings localization;


    public enum Languages{
        English,
        German
    }


    public void SetLocalisation(int languageIndex)
    {
        resetGameButton.text = localization.resetGame[languageIndex];
        changeLanguageText.text = localization.changeLanguage[languageIndex];
        aboutButton.text = localization.about[languageIndex];
        //Make a line like this for every new line you added to the SerializeField list
    }




}
