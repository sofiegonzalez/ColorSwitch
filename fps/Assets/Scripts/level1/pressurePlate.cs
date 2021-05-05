using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    //corresponding crate and crate script variable currColor
    public GameObject crate;
    private crateColorChange cs;
    public string currColor;

    //puzzle solved variable
    public bool solved = false;

    // Start is called before the first frame update
    void Start()
    {
        //cs is the crate script with public currColor variable
        cs = crate.GetComponent<crateColorChange>();
    }

    // Update is called once per frame
    void Update()
    {
        //if crate color same as pressure plate color, puzzle is solved
        if(cs.currColor == currColor){
            solved = true;
        }
        else
        {
            //puzzle not solved
            solved = false;
        }
        
    }
}
