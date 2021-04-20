using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_crate_fall : MonoBehaviour
{
    public string crate_color;
    public crateColorChange crate;
    private Collider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //get current gun color
        string currColor = crate.GetComponent<crateColorChange>().currColor;

        //if player gun is on the same color as the cube platform, can walk on it
        if (currColor == crate_color)
        {
            //Debug.Log("same");
            //player can stand on cube
            myCollider.enabled = true;
        }
        else
        {
            //player is unable to stand on platform if gun is not set to the same color
            //Debug.Log("not same");
            //player falls through cube
            myCollider.enabled = false;
        }
    }

    }
