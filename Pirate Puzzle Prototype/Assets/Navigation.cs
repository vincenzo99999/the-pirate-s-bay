using System.Collections;
using System.Collections.Generic;
using Apple.Accessibility;
using TMPro;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    /* IMPORTANT: buttons should always be direct children of Screens or navigation 
     * will not work because of shenaningans (thanks apple)*/


    [SerializeField] GameObject screenToGo;
    [SerializeField] TextMeshProUGUI hintText;

    [SerializeField] string[] hints;

    [SerializeField] int hintNumber = 0;

    private bool hasAccessibility = false;


    private void Start()
    {
        //Check if has accessibility component
        AccessibilityNode node;
        if (TryGetComponent<AccessibilityNode>(out node))
        {
            hasAccessibility = true;
            GameObject accessibilityParent = new GameObject(gameObject.name + "_AccParent", typeof(RectTransform));
            accessibilityParent.transform.position = transform.position;
            accessibilityParent.transform.SetParent(transform.parent);
            AccessibilityNode parentNode = accessibilityParent.AddComponent<AccessibilityNode>();

            parentNode.AccessibilityLabel = node.AccessibilityLabel;
            parentNode.AccessibilityTraits = node.AccessibilityTraits;
            parentNode.AccessibilityHint = node.AccessibilityHint;
            parentNode.AccessibilityIdentifier = node.AccessibilityIdentifier;
            parentNode.AccessibilityValue = node.AccessibilityValue;

            node.enabled = false;

            transform.SetParent(accessibilityParent.transform);
        }


            
    }

    public void NavigateTo()
    {
        screenToGo.SetActive(true);
        //Go up two layers 'cause of accessibility
        if(hasAccessibility)
            transform.parent.
                transform.parent.
                gameObject.SetActive(false);
        else
            transform.parent.
gameObject.SetActive(false);

    }

    public void NavigateToHint()
    {
        NavigateTo();
        hintText.text = hints[hintNumber];

        if(hintNumber < 2)
            hintNumber++;
    }
}
