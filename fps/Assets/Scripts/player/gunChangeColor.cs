using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunChangeColor : MonoBehaviour
{
    //control gun color and player input
    public float targetDistance = 0.0f;
    public int allowedRange = 15;
    public Material red;
    public Material blue;
    public Material green;

    //start color of gun
    public string color = "red";
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
            }
            else if(color == "blue")
            {
                color = "green";
                //change color of laser
                laser.GetComponent<MeshRenderer>().material = green;
            }
            else
            {
                color = "red";
                //change color of laser
                laser.GetComponent<MeshRenderer>().material = red;
            }
            //change color click sound
            color_change.Play();
            
        }
            
        //left click- fire gun
        if (Input.GetButtonDown("Fire1"))
        {
            //use raycasting to determine user distance from objects in scene
            RaycastHit shot;
            if ( Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
                if(targetDistance < allowedRange)
                {
                    //call ChangeColor funtion in crate script to change colro of crate
                    //have a check if pointed at a crate or not
                    shot.transform.SendMessage("ChangeColor", color);
                    
                }
                
            }
        }

    }
}
