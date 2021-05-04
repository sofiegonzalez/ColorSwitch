using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeFell : MonoBehaviour
{
    Vector3 resetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        resetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -20) //if the cube falls down in the abyss
        {
            transform.position = resetPos; //reset it back to where it spawned
        }
    }
}
