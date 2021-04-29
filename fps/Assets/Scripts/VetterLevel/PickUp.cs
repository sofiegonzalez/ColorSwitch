using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
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
            transform.position = heldLocation.transform.position;
            transform.rotation = heldLocation.transform.rotation;
        }
        
        if (Input.GetKeyDown("e"))
        {
            if (isPickedUp)
            {
                isPickedUp = false;
                GetComponent<Rigidbody>().useGravity = true;
                transform.parent = null;
            }
            else if(withinRange)
            {
                GetComponent<Rigidbody>().useGravity = false;
                transform.parent = heldLocation.transform;
                transform.position = heldLocation.transform.position;
                isPickedUp = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        withinRange = true;
        Debug.Log("Within Range");
    }

    private void OnTriggerExit(Collider other)
    {
        withinRange = false;
        Debug.Log("Out of Range");
    }
}
