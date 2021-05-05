using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player moves through door when solved, load next level
        if(transform.position.x <= -2)
        {
            SceneManager.LoadScene("level2");
        }
    }
}
