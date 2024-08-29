using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleTryAgainScript : MonoBehaviour
{
    //We need to create two variables!
    //This variable will hold the KeyCode for Y
    public KeyCode Retry;
    public KeyCode Fail;
    //This variable will hold the KeyCode for N
    void Update()
    {
        if (Input.GetKeyDown(Retry))
        {
            //Return to the first level 
            SceneManager.LoadScene(0);
        }

        if(Input.GetKeyDown(Fail)) 
        { 
            //Turn off game
            Application.Quit(); 
        }
    }
}
