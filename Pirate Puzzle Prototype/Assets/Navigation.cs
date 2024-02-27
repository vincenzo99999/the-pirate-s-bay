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
    

    private void Start()
    {
        
        AccessibilityNode node = GetComponent<AccessibilityNode>();
        

        GameObject accessibilityParent = new GameObject(gameObject.name + "_AccParent", typeof(RectTransform));
        accessibilityParent.transform.position = transform.position;
        accessibilityParent.transform.SetParent(transform.parent);
        transform.SetParent(accessibilityParent.transform);

            
    }

    public void NavigateTo()
    {
        screenToGo.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }

    public void NavigateToHint()
    {
        NavigateTo();
        hintText.text = hints[hintNumber];

        if(hintNumber < 2)
            hintNumber++;
    }
}
