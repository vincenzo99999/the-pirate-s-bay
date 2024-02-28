using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoomLevelScript : MonoBehaviour
{
    private const string password = "Spongebob";
    [SerializeField] TMP_InputField inputField;
    

    public void CheckEnteredPassword()
    {
        Debug.Log(inputField.text == password);
        if(inputField.text == password)
        {
            Debug.Log("U won");
        }
    }


}
