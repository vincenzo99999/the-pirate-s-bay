using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using Apple.Accessibility;
using UnityEngine;


public class LocalisedObject : MonoBehaviour
{

    [SerializeField] string[] localisedText;

    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        AccessibilityNode node;
        if (TryGetComponent(out node))
        {
            node.AccessibilityLabel = localisedText[0];
        }
        else
        {
            //Add it if it didn't have it already
            node = gameObject.AddComponent<AccessibilityNode>();
            node.AccessibilityLabel = localisedText[0];
            
            Debug.Log($"Added accessibility to: {gameObject.name}", gameObject);

            //Check if it's a button
            if (IsButton())
                node.AccessibilityTraits = AccessibilityTrait.Button;


        }

    }

    public void SetLanguage(int languageIndex)
    {
        textMesh.text = localisedText[languageIndex];

        AccessibilityNode node;
        if (TryGetComponent(out node))
        {
            node.AccessibilityLabel = localisedText[languageIndex];
        }
        else
        {
            //Add it if it didn't have it already
            node = gameObject.AddComponent<AccessibilityNode>();
            node.AccessibilityLabel = localisedText[languageIndex];

            Debug.Log($"Added accessibility to: {gameObject.name}");

            //Check if it's a button
            if (IsButton())
                node.AccessibilityTraits = AccessibilityTrait.Button;


        }

    }

    private bool IsButton()
    {
        Button b;
        return transform.parent.
            TryGetComponent(out b);
    }


}