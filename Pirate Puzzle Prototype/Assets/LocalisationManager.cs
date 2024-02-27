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


    private LocalisedObject[] localisedObjects;

    private void OnEnable()
    {
        localisedObjects = FindObjectsOfType<LocalisedObject>();
    }


    public void SetLocalisation(int languageIndex)
    {
        
        OnEnable(); //This fixed the issue. On bigger project should be optimized but fuck it, we ball
        foreach(LocalisedObject localisedObject in localisedObjects)
        {
            localisedObject.SetLanguage(languageIndex);
        }
    }


}
