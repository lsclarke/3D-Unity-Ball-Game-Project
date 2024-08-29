using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleScoreManagerScript : MonoBehaviour
{
    //We must create 2 variables!
    //One that keeps track of the point value of a coin
    //One that can access the score text!

    public int scoreValue;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        //Set your text to equal a new string!
        scoreText.text = "Score: " + scoreValue;
    }
}
