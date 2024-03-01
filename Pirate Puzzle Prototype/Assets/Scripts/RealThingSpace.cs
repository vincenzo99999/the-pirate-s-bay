using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealThingSpace : MonoBehaviour
{
    [Tooltip("As real thing i mean the sprite space scene.")]
    [SerializeField] GameObject realThing;


    private void OnEnable()
    {
        realThing.SetActive(true);
    }

    private void OnDisable()
    {
        realThing.SetActive(false);
    }
}
