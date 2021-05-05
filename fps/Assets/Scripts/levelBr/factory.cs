using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public GameObject ball; // boulder prefab rolls down the track
    public float spawn_time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // reset spawn timer to 0
        spawn_time -= Time.deltaTime;
        if (spawn_time <= 0f)
        {
            // create a boulder
            Instantiate(ball, transform.position, transform.rotation);
            // wait time for next boulder to spawn
            spawn_time = 9.0f;
        }
    }
}
