using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    //player clicks start button -> level 1 scene loaded
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //player clicks exit button -> game quits
    public void Exit()
    {
        Debug.Log("user quit game");
        Application.Quit();
    }
}
