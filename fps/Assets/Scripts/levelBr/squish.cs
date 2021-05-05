using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class squish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when the user touches the boulders they get "squished"
    void OnCollisionEnter(Collision col)
    {
        // restart the level from the begining
        SceneManager.LoadScene("levelBr");
    }
}
