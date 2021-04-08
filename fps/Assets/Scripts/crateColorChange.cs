using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateColorChange : MonoBehaviour
{
    public Material start;
    public Material red;
    public Material blue;
    public Material green;
    public string currColor;

    // Start is called before the first frame update
    void Start()
    {
        //starting color
        GetComponent<MeshRenderer>().material = start;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor(string newColor)
    {
        //new color is the color the gun is set on
        if(newColor == "green"){
            //change object color when shot
            GetComponent<MeshRenderer>().material = green;
            currColor = "green";
        }
        else if (newColor == "red")
        {
            
            GetComponent<MeshRenderer>().material = red;
            currColor = "red";
        }
        else
        {
            
            GetComponent<MeshRenderer>().material = blue;
            currColor = "blue";
        }

    }
}
