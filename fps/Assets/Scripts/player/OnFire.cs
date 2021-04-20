using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour
{

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //left click, gun is shot and laser sound effect played
        if(Input.GetButtonDown("Fire1")){
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            //gun animation recoil
            //GetComponent<Animation>().Play("shoot");
        }
    }

}
