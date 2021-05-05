using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_fall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Once the boulder falls to the end of the track, destroy it
        if (transform.position.y <= -25)
        {
            Destroy(gameObject);
        }
    }
}
