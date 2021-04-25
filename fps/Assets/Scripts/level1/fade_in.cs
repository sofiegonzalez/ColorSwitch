﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fade_in : MonoBehaviour
{
    public Text t1;
    public Text t2;
    private int start = 0;
    private int second = 1;
    private int third = 1;
    private int fourth = 1;
    void Start()
    {
       
    }
    // can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
        if(start == 0)
        {
            StartCoroutine(fadeIn(2f, t1));
            second = 0;
            start = 1;
        }
        
        if (Input.GetMouseButtonDown(1) && second == 0)
        {
            StartCoroutine(fadeOut(2f, t1));
            second = 1;
            third = 0;
        }

        if (third == 0)
        {
            StartCoroutine(fadeIn(2f, t2));
            third = 1;
            fourth = 0;

        }

        if (Input.GetMouseButtonDown(0) && fourth == 0)
        {
            StartCoroutine(fadeOut(2f, t2));
            fourth = 1;

        }

    }



    public IEnumerator fadeIn(float t, Text i)
    {
       
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        start = 1;
    }

    public IEnumerator fadeOut(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
