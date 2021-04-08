using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solution : MonoBehaviour
{
    private bool solved_crate1 = false;
    private bool solved_crate12 = false;
    public GameObject crate1;
    public GameObject crate2;
    private pressurePlate c1;
    private pressurePlate c2;

    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        //this puzzle has two crates
        c1 = crate1.GetComponent<pressurePlate>();
        c2 = crate2.GetComponent<pressurePlate>();
    }

    // Update is called once per frame
    void Update()
    {
        if(c1.solved && c2.solved)
        {
            //Debug.Log("puzzle solved");
            GetComponent<MeshRenderer>().material = green;

            StartCoroutine(SmoothLerp(1f));
        }
    }

    private IEnumerator SmoothLerp(float time)
    {
        Vector3 startingPos = transform.position;
        Vector3 finalPos = new Vector3(-2.01f, 3.069f, -18.6f);
        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
