using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovingPlatformScript : MonoBehaviour
{
    //We need to create 3 veriables
    //1 variable will be in charge of an array of spots the platform can move to
    //1 will be the number location the platform is at
    //1 will be the speed the platform will travel at
    public Transform[] MoveToSpot;
    private int LocationPoint = 0;
    public float TravelSpeed;

    // Update is called once per frame
    void Update()
    {
        //Create a new float variable that will be in charge of moving the platform over time 
        float movement = TravelSpeed * Time.deltaTime;

        //If our current platform's position doesn't equal any of these points then move our platform to one of these positions
        if(transform.position != MoveToSpot[LocationPoint].position)
        {
            //move our platform to one of these positions
            transform.position = Vector3.MoveTowards(transform.position, MoveToSpot[LocationPoint].position, movement);
        }
        else
        {
            //If our location reaches the max number of spots we can move to, reset it back to 0
            if(LocationPoint + 1 == MoveToSpot.Length)
            {
                LocationPoint = 0;
            }
            else
            {
                //Continue to the next position
                LocationPoint++;
            }
        }
        
    }
}
