using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //location attached to the player that the block will go to 
    public GameObject heldLocation;
    bool isPickedUp;
    bool withinRange;
    
    // Start is called before the first frame update
    void Start()
    {
        isPickedUp = false;
        withinRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp)
        {
            transform.position = heldLocation.transform.position; //maintains position of cube
            transform.rotation = heldLocation.transform.rotation; //prevents strange rotations from occuring
            transform.localScale = new Vector3(50, 50, 50); //reduced size to prevent taking up the screen
        }
        
        if (Input.GetKeyDown("e")) //e is the command to pick up and put down the cube
        {
            if (isPickedUp) //handles setting the cube down
            {
                isPickedUp = false;
                GetComponent<Rigidbody>().useGravity = true;
                transform.parent = null;
                transform.localScale = new Vector3(100, 100, 100); //returns the cube to original size

                //assists with making placing the cube down a little more smooth feeling
                transform.position = heldLocation.transform.position + heldLocation.transform.forward; 
            }
            else if(withinRange) //handles picking up the cube
            {
                GetComponent<Rigidbody>().useGravity = false;
                transform.parent = heldLocation.transform;
                transform.position = heldLocation.transform.position;
                isPickedUp = true;
            }
        }
    }

    //handles the case of ensuring that the block is close enough to the player when they try and pick it up
    private void OnTriggerEnter(Collider other)
    {
        withinRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        withinRange = false;
    }
}
