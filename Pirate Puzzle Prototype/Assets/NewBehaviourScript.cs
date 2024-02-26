using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float snapAmount = 0.5f;  
    [SerializeField] Vector3 previousPosition;

    [SerializeField] AudioSource bumpSound;
    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
        //now it's just gonna bump back
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Isentering");
        if (other.tag == "Respawn")
        {

            bumpSound.time = .1f;
            bumpSound.Play();

            Debug.Log("Isentering2");
            transform.position = previousPosition;
        }
        else if (other.tag == "Finish")
        {
            //pass (loadNextLevel();)
            Debug.Log("U won");
            
        }
    }



    public void MoveRight()
    {
        previousPosition = transform.position;
        transform.position += Vector3.right * snapAmount;
    }
    public void MoveLeft()
    {
        previousPosition = transform.position;
        transform.position += Vector3.left * snapAmount;
    }
    public void MoveUp()
    {
        previousPosition = transform.position;
        transform.position += Vector3.up * snapAmount;
    }
    public void MoveDown()
    {
        previousPosition = transform.position;
        transform.position += Vector3.down * snapAmount;
    }
}
