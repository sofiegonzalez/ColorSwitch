using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public GameObject crate;
    private crateColorChange cs;
    public string currColor;
    public bool solved = false;
    // Start is called before the first frame update
    void Start()
    {
        cs = crate.GetComponent<crateColorChange>();
        //make currColor color of the material used
        //currColor = material color
    }

    // Update is called once per frame
    void Update()
    {
        if(cs.currColor == currColor){
            solved = true;
            //Debug.Log("solved");

        }
        else
        {
            solved = false;
        }
        
    }
}
