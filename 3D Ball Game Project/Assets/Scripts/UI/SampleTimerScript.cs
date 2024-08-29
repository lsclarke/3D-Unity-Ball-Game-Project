using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleTimerScript : MonoBehaviour
{
    //We must create 2 variables!
    //One that keeps track of the remaing time value
    //One that can access the timer text!
    [Range(10,120)]
    public float remainingTime;
    public TextMeshProUGUI timerText;


    private void Update()
    {
        //Since we are counting down we want the remaininTime to be subdtracted by every second
        remainingTime -= Time.deltaTime;

        //Create 2 variables for Minutes and Seconds*

        //Use Mathf.FloorToInt(variable / 60 seconds) for minutes
        int minutes = Mathf.FloorToInt(remainingTime / 60);

        //Use Mathf.FloorToInt(variable / 60 seconds)
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        //Set your text to equal a new string format!
        //string.Format(string format, minutes, seconds)
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //If the remaining time is less than or equal to 0
        if (remainingTime <= 0 )
        {
            //Load the Lose Screen
            SceneManager.LoadScene("Lose Screen");
        }
    }

}
