using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float snapAmount = 0.5f;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {

    }

    public void MoveRight()
    {
        transform.position += Vector3.right * snapAmount;
    }
    public void MoveLeft()
    {
        transform.position += Vector3.left * snapAmount;
    }
    public void MoveUp()
    {
        transform.position += Vector3.up * snapAmount;
    }
    public void MoveDown()
    {
        transform.position += Vector3.down * snapAmount;
    }
}
