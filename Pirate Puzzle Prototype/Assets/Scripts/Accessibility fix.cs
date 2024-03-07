using System.Collections;
using System.Collections.Generic;
using Apple.Accessibility;
using UnityEngine;


public class Accessibilityfix : MonoBehaviour
{

    AccessibilityNode parentNode;


    private void Start()
    {
        AccessibilityNode node;
        //Check if has accessibility component
        if (TryGetComponent<AccessibilityNode>(out node))
        {
            GameObject accessibilityParent = new GameObject(gameObject.name + "_AccParent", typeof(RectTransform));
            accessibilityParent.transform.position = transform.position;
            accessibilityParent.transform.SetParent(transform.parent);
            parentNode = accessibilityParent.AddComponent<AccessibilityNode>();

            parentNode.AccessibilityLabel = node.AccessibilityLabel;
            parentNode.AccessibilityTraits = node.AccessibilityTraits;
            parentNode.AccessibilityHint = node.AccessibilityHint;
            parentNode.AccessibilityIdentifier = node.AccessibilityIdentifier;
            parentNode.AccessibilityValue = node.AccessibilityValue;

            node.enabled = false;

            transform.SetParent(accessibilityParent.transform);

            parentNode.accessibilityLabelDelegate = () =>
            {
                return node.AccessibilityLabel;
            };

            parentNode.accessibilityValueDelegate = () =>
            {
                return node.AccessibilityValue;
            };
        }
    }

}
