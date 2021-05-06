using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFirstDoor : MonoBehaviour
{
    public GameObject plate;
    private complexPressurePlate p1;
    private Vector3 openPos = new Vector3(-34.85479f, 15.1f, 8.260815f);
    private Vector3 closedPos = new Vector3(-34.85479f, 5.20663f, 8.260815f);

    private bool isMoving;
    private bool isClosed;
    private bool doorOpen = false;
    private AudioSource opendoor;


    // Start is called before the first frame update
    void Start()
    {
        p1 = plate.GetComponent<complexPressurePlate>();
        isMoving = false;
        isClosed = true;
        opendoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving) //prevents changes in door movement while already moving
        {
            if (p1.solved) // if the puzzle is solved
            {
                if (isClosed && doorOpen == false) //open the door if its closed
                {
                    Debug.Log("open");
                    isMoving = true;
                    isClosed = false;
                    StartCoroutine(SmoothLerp(2f, openPos));
                    doorOpen = true;
                }
            }
            else //if the puzzle isnt solved
            {
                if (!isClosed && doorOpen == true) //close the door if it isnt already
                {
                    Debug.Log("close");
                    isMoving = true;
                    StartCoroutine(SmoothLerp(2f, closedPos));
                    isClosed = true;
                    doorOpen = false;
                }
            }
        }
        //Debug.Log(transform.position);
    }

    //will slowly open the door
    private IEnumerator SmoothLerp(float time, Vector3 targetPos)
    {
        Vector3 startingPos = transform.position;

        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            transform.position = Vector3.Lerp(startingPos, targetPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }

        isMoving = false;
        opendoor.Play();
    }
}

