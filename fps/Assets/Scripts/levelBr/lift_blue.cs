using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift_blue : MonoBehaviour
{
    public GameObject pressure;
    public Vector3 finalPos;
    private pressurePlate c;


    // Start is called before the first frame update
    void Start()
    {
        c = pressure.GetComponent<pressurePlate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (c.solved)
        {
            StartCoroutine(SmoothLerp(1f));
            c.solved = false;
        }
    }

    //move blue up
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