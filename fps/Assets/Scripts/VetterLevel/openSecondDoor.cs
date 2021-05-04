using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSecondDoor : MonoBehaviour
{
    public GameObject plate1;
    public GameObject plate2;
    private complexPressurePlate p1;
    private complexPressurePlate p2;

    Vector3 finalpos = new Vector3(0.921f, 8f, -193.43f);

    // Start is called before the first frame update
    void Start()
    {
        p1 = plate1.GetComponent<complexPressurePlate>();
        p2 = plate2.GetComponent<complexPressurePlate>();
    }

    // Update is called once per frame
    void Update()
    {
        //if both pressure plates are solved then open the door
        if(p1.solved && p2.solved)
        {
            StartCoroutine(SmoothLerp(2f, finalpos));
        }
    }

    //slowly open the door
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
    }
}
