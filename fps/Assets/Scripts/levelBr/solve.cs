using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solve : MonoBehaviour
{
    // two pressure plates from puzzle rooms
    public GameObject pressure1;
    public GameObject pressure2;
    // move the door up to this position
    public Vector3 finalPos;
    private pressurePlate c1;
    private pressurePlate c2;
    // play sound, turn door green
    private AudioSource opendoor;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        //this puzzle has two crates that will open the exit dorr
        c1 = pressure1.GetComponent<pressurePlate>();
        c2 = pressure2.GetComponent<pressurePlate>();
        opendoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (c1.solved && c2.solved)
        {
            GetComponent<MeshRenderer>().material = green;
            opendoor.Play();

            StartCoroutine(SmoothLerp(1f));
            c1.solved = false;
            c2.solved = false;
        }
    }

    //move the door open
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