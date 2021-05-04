using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complexPressurePlate : MonoBehaviour
{
    public bool solved;
    private crateColorChange crate;
    public string currColor;
    private bool isOn;
    
    // Start is called before the first frame update
    void Start()
    {
        solved = false; //puzzle isn't solved initially
        isOn = false;
    }

    private void Update()
    {
        if(isOn)
        {
            if (crate.currColor == currColor) //if the colors match then the puzzle is solved
            {
                solved = true;
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "crate") //checks if a viable crate is on the plate
        {
            crate = collision.gameObject.GetComponent<crateColorChange>(); //get its component
            isOn = true;
            if (crate.currColor == currColor) //if the colors match then the puzzle is solved
            {
                solved = true;
                
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "crate") //when that same crate leaves, the puzzle becomes unsolved
        {
            solved = false;
            isOn = false;
        }
    }
}
