using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;

    private bool atOne;
    private bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        atOne = false;
        isMoving = false;
        //Debug.Log(pos1);
        transform.position = pos1;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (!isMoving)
        {
            if (atOne)
            {
                Debug.Log("Moving to two");
                StartCoroutine(MoveToPos(pos2));
                isMoving = true;
                atOne = false;
            }
            else
            {
                Debug.Log("Moving to one");
                StartCoroutine(MoveToPos(pos1));
                isMoving = true;
                atOne = true;
            }
        }*/
    }

    private IEnumerator MoveToPos(Vector3 targetPos)
    {
        Vector3 startPos = transform.position;
        float timer = 0;
        float transitionTime = 8f;
        //Debug.Log("start pos is ");
        //Debug.Log(startPos);
       // Debug.Log("target pos is");
        //Debug.Log(targetPos);

        while (timer < transitionTime)
        {
            transform.position = Vector3.Lerp(startPos, targetPos, (timer / transitionTime));
            timer += Time.deltaTime;
        }
        isMoving = false;
        yield return null;
    }
}
