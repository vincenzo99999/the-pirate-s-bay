using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Navigation : MonoBehaviour
{

    [SerializeField] GameObject screenToGo;
    [SerializeField] TextMeshProUGUI hintText;

    [SerializeField] string[] hints;

    [SerializeField] int hintNumber = 0;


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
