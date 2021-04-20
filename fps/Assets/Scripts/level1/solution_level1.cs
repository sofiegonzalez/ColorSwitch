using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solution_level1 : MonoBehaviour
{
    private bool solved_crate1 = false;
    private bool solved_crate12 = false;
    public GameObject pressure1;
    public GameObject pressure2;
    
    public Vector3 finalPos;

    private pressurePlate c1;
    private pressurePlate c2;
    private AudioSource opendoor;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        //this puzzle has two crates
        c1 = pressure1.GetComponent<pressurePlate>();
        c2 = pressure2.GetComponent<pressurePlate>();
        opendoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(c1.solved && c2.solved)
        {
            //Debug.Log("puzzle solved");
            
            GetComponent<MeshRenderer>().material = green;
            //cant get open door sound to play?
            opendoor.Play();

            StartCoroutine(SmoothLerp(1f));
            c1.solved = false;
            c2.solved = false;
        }
    }

    //move door open
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
    }
}
