using System.Collections;
using System.Collections.Generic;
using TMPro;
using Apple.Accessibility;
using UnityEngine;


public class LocalisationManager : MonoBehaviour
{

    private LocalisedObject[] localisedObjects;
    private TextMeshProUGUI[] texts;

    private void OnEnable()
    {
        //Gets all objects with the LocalisedObject script
        localisedObjects = FindObjectsOfType<LocalisedObject>();

        //If in editor (not in release)
        if (Application.isEditor)
        {
            //Save the currently active screen
            GameObject currentScreen = GameObject.FindGameObjectWithTag("Screen");

            ScreenManager[] screens = Resources.FindObjectsOfTypeAll<ScreenManager>();

            //Set all screen active
            foreach(ScreenManager screen in screens)
            {
                screen.gameObject.SetActive(true);
            }

            //Get all objects with a text
            texts = FindObjectsOfType<TextMeshProUGUI>();

            //Check their localisation
            foreach(TextMeshProUGUI text in texts)
            {
                GameObject obj = text.gameObject;
                LocalisedObject localisedObject;

                if(!obj.TryGetComponent(out localisedObject))
                {
                    Debug.LogWarning($"Localisation Warning: {obj.name} is missing LocalisedObject component", obj);
                }

            }
            //Disable all screens, but the previously active one
            foreach (ScreenManager screen in screens)
            {
                if(!ReferenceEquals(screen.gameObject,currentScreen))
                    screen.gameObject.SetActive(false);
            }

        }



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
