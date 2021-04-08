using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunChangeColor : MonoBehaviour
{
    public float targetDistance = 0.0f;
    public int allowedRange = 15;
    public Material red;
    public Material blue;
    public Material green;

    //start color of gun
    string color = "red";
    public GameObject laser;
    private AudioSource color_change;


    // Start is called before the first frame update
    void Start()
    {
        //set material to red- start color
        laser.GetComponent<MeshRenderer>().material = red;

        color_change = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //right click- change color
        //continous right click circles through red -> blue -> green
        if (Input.GetMouseButtonDown(1))
        {
            if(color == "red")
            {
                color = "blue";
                //change color of laser
                laser.GetComponent<MeshRenderer>().material = blue;
                Debug.Log("new color blue");
            }
            else if(color == "blue")
            {
                color = "green";
                //change color of laser
                laser.GetComponent<MeshRenderer>().material = green;
                Debug.Log("new color green");
            }
            else
            {
                color = "red";
                //change color of laser
                laser.GetComponent<MeshRenderer>().material = red;
                Debug.Log("new color red");
            }
            color_change.Play();
        }
            
        //left click- fire gun
        if (Input.GetButtonDown("Fire1"))
        {
            //use raycasting to determine user distance from objects in scene
            RaycastHit shot;
            if( Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
                if(targetDistance < allowedRange)
                {
                    //call ChangeColor funtion in crate script to change colro of crate
                    shot.transform.SendMessage("ChangeColor", color);
                    
                }
                
            }
        }

    }
}
