using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCoinScript : MonoBehaviour
{
    //We must create 1 variable that keeps track of the point value of a coin!
    //We must create 1 variable that access the SampleScoreManagerScript !

    public int pointValue;

    //This variable calls on the SampleScoreManagerScript, this will allow you to access all pubic components/properties of this script within your current one!
    public SampleScoreManagerScript scoreManager;

    //Create a new custom method that updates the score of your player!
    public int AddScore()
    {
        //Have your score from the ScoreManager add to the points
        //value1 + value2 = total
        scoreManager.scoreValue += pointValue;
        return pointValue;
    }

    //Add a OnTriggerEnter() Method, to check for collision
    private void OnTriggerEnter(Collider other)
    {
        //Create a if statement that checks if coin is collides with player
        if (other.gameObject.tag == "Player")
        {
            //Destroy game object and add to the score
            Destroy(gameObject);
            AddScore();
        }
    }
}
