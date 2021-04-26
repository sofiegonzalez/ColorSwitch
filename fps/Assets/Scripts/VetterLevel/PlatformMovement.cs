using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;
    public float speed = 20f;
    public int direction = 1;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position = pos1;
    }


    void Update()
    {
        
        if (transform.position.x > pos1.x)
        {
            direction = -1;
        }
        else if (transform.position.x < pos2.x)
        {
            direction = 1;
        }
        movement = Vector3.right * direction * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
