using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solution_level1 : MonoBehaviour
{
    //crates and pressure plates
    private bool solved_crate1 = false;
    private bool solved_crate12 = false;
    public GameObject pressure1;
    public GameObject pressure2;
    private pressurePlate c1;
    private pressurePlate c2;

    //final position, color and sound for the door
    public Vector3 finalPos;
    private AudioSource opendoor;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        //this puzzle has two crates
        c1 = pressure1.GetComponent<pressurePlate>();
        c2 = pressure2.GetComponent<pressurePlate>();
        //audio open door sound
        opendoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if both pressure plates have cubes with matching colors on them
        if(c1.solved && c2.solved)
        {

            //puzzle solved, open door and play sound
            GetComponent<MeshRenderer>().material = green;
            opendoor.Play();
            //open door to next level coroutine
            StartCoroutine(SmoothLerp(1f));
            //set solved to false
            c1.solved = false;
            c2.solved = false;
        }
    }

    //coroutine to open door
    private IEnumerator SmoothLerp(float time)
    {
        Vector3 startingPos = transform.position;
        
        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            //lerp to smoothly open door to final position
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
