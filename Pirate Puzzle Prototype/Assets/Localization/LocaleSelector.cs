using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine;

public class LocaleSelector : MonoBehaviour
{

    private bool isChangingLocale = false;

    public void ChangeLocale(int localeID)
    {
        //If is changing locale already wait for it to finish
        if (isChangingLocale) return;
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int _localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
    }


}
