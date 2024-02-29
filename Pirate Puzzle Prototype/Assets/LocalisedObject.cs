using System.Collections;
using System.Collections.Generic;
using TMPro;
using Apple.Accessibility;
using UnityEngine;


public class LocalisedObject : MonoBehaviour
{

    [SerializeField] string[] localisedText;

    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void SetLanguage(int languageIndex)
    {
        textMesh.text = localisedText[languageIndex];


        if (textMesh.gameObject.TryGetComponent())
        {

        }

    }


}
