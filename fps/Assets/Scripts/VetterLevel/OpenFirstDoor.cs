using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFirstDoor : MonoBehaviour
{
    public GameObject plate;
    
    private pressurePlate p1;
    private Vector3 openPos = new Vector3(-34.85479f, 15.1f, 8.260815f);
    private Vector3 closedPos = new Vector3(-34.85479f, 5.20663f, 8.260815f);

    private bool isMoving;
    private bool isClosed;

    // Start is called before the first frame update
    void Start()
    {
        p1 = plate.GetComponent<pressurePlate>();
        isMoving = false;
        isClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            if (p1.solved)
            {
                if (isClosed)
                {
                    Debug.Log("open");
                    isMoving = true;
                    isClosed = false;
                    openDoor();
                }
            }
            else
            {
                if (!isClosed)
                {
                    Debug.Log("close");
                    isMoving = true;
                    closeDoor();
                    isClosed = true;
                }
            }
        }
        //Debug.Log(transform.position);
    }

    void openDoor()
    {
        float elapsedTime = 0;

        while (elapsedTime < 2f)
        {
            transform.position = Vector3.Lerp(closedPos, openPos, (elapsedTime / 2f));
            elapsedTime += Time.deltaTime;
        }

        isMoving = false;
    }

    void closeDoor()
    {
        float elapsedTime = 0;

        while (elapsedTime < 2f)
        {
            transform.position = Vector3.Lerp(openPos, closedPos, (elapsedTime / 2f));
            elapsedTime += Time.deltaTime;
        }

        isMoving = false;
    }
}

//maybe use this for a smooth lerp- coroutine
/*//move door open
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
}*/
