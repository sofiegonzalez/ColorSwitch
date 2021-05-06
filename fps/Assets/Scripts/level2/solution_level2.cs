using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solution_level2 : MonoBehaviour
{
    //solution script for level2
    private bool solved_crate1 = false;

    //final pos, material and open sound for door
    public Vector3 finalPos;
    private AudioSource opendoor;
    public Material green;

    //pressure plate info
    public GameObject pressure1;
    private pressurePlate c1;

    private bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        //this puzzle has one crate
        c1 = pressure1.GetComponent<pressurePlate>();
        opendoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if puzzle solved, open door
        if (c1.solved && doorOpen == false)
        {

            GetComponent<MeshRenderer>().material = green;

            //coroutuine to smoothly open door
            StartCoroutine(SmoothLerp(1f));
            //set puzzle to false
            c1.solved = false;
            doorOpen = true;
        }
    }

    //coroutine to open door
    private IEnumerator SmoothLerp(float time)
    {
        Vector3 startingPos = transform.position;

        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        
        opendoor.Play();
    }
}
