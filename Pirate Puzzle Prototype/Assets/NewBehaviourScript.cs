using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float snapAmount = 0.5f;
    [SerializeField] Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Isentering");
        if (other.tag == "Respawn")
        {
            Debug.Log("Isentering2");

            transform.position = initialPosition;
        }
        else if (other.tag == "Finish")
        {
            //pass (loadNextLevel();)
            Debug.Log("U won");
            transform.position = initialPosition;
        }
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
