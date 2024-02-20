using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{

    [SerializeField] GameObject screenToGo;
    [SerializeField] TextMesh hintText;

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

        //To finish
        hintNumber++;
    }
}
