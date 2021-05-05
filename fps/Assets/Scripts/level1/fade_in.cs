using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fade_in : MonoBehaviour
{
    //script to fade text in when level starts
    public Text t1;
    public RawImage t2;
    private int start = 0;
    private int second = 1;
    private int third = 1;
    private int fourth = 1;

    void Start()
    {
       
    }

    void Update()
    {
        //if start = 0, trigger coroutines to fade in text and image
        if(start == 0)
        {
            StartCoroutine(fadeIn(2f, t1));
            StartCoroutine(fadeInIm(2f, t2));
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

    public IEnumerator fadeInIm(float t, RawImage i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        start = 1;
    }

    //fade out coroutine
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
