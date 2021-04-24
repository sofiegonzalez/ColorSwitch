using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFirstDoor : MonoBehaviour
{
    public GameObject plate;
    
    private pressurePlate p1;
    private Vector3 openPos = new Vector3(-22.8f, -0.4f, 35.2f);
    private Vector3 closedPos = new Vector3(-22.8f, -0.4f, 40.2f);

    private bool isMoving;
    private bool isClosed;

    // Start is called before the first frame update
    void Start()
    {
        p1 = plate.GetComponent<pressurePlate>();
        isMoving = false;
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
                    isMoving = true;
                    openDoor();
                    isClosed = false;
                }
            }
            else
            {
                if (!isClosed)
                {
                    isMoving = true;
                    closeDoor();
                    isClosed = true;
                }
            }
        }
        Debug.Log(transform.position);
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
