using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSpikeScript : MonoBehaviour
{
    //We need to make an OnCollisionEnter method to check for the collision of the player
    private void OnCollisionEnter(Collision other)
    {
        //Create a if statement that checks if coin is collides with player
        if (other.gameObject.tag == "Player")
        {
            //Destroy the player object
            Destroy(other.gameObject);
            //Start a Coroutine (Basically a timer) to activate the next method
            StartCoroutine(DeathTimer(2f));
        }
    }

    //We need to make an IEnumerator method, this is used to pause and then activate a specific piece of code within unity
    private IEnumerator DeathTimer(float waitTime)
    {
        //Wait a certain amount of time
        yield return waitTime;
        //Go to lose scene when time is up
        SceneManager.LoadScene("Lose Screen");
    }
}
