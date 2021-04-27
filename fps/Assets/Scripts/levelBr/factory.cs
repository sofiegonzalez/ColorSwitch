using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public GameObject ball;
    public float spawn_time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawn_time -= Time.deltaTime;
        if (spawn_time <= 0f)
        {
            Instantiate(ball, transform.position, transform.rotation);
            spawn_time = 9.0f;
        }
    }
}
