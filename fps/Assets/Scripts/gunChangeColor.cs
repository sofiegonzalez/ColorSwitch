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

    string color = "red";
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        laser.GetComponent<MeshRenderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        //right click- change color
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
                laser.GetComponent<MeshRenderer>().material = green;
                Debug.Log("new color green");
            }
            else
            {
                color = "red";
                laser.GetComponent<MeshRenderer>().material = red;

            }
        }
            

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit shot;
            if( Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
            {
                targetDistance = shot.distance;
                if(targetDistance < allowedRange)
                {
                    //here we would change the color
                    shot.transform.SendMessage("ChangeColor", color);
                    
                }
                
            }
        }

    }
}
