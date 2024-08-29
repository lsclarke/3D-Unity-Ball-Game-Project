using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovementScript : MonoBehaviour
{
    //We must create 4 variables!
    //one that will controll the speed of our ball
    //one that acesses Rigidbody for use to use Game Physics
    //2 for movement on the Horizontal and Vertical Axis

    [Range(0f,10f)]
    public float speed;

    //Rigidbody is Game Physics!
    public Rigidbody physics;

    private float InputHorizontal;
    private float InputVertical;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Set your Input variables you made to the Axis they are going to be used for. This will allow for you to get the exact axis the player will be moving on be sure to type the exact name of the axis
        InputHorizontal = Input.GetAxis("Horizontal");
        InputVertical = Input.GetAxis("Vertical");

        //Create a new Vector3 variable, This will be used create a brand new velocity for your ball. Multiply the Input variable and the speed variable in the X and the Z only! 
        Vector3 move = new Vector3(InputHorizontal * speed, physics.velocity.y, InputVertical * speed);
        //                        (right and left motion  , Up and Down motion, Forward and Backward motion)

        //Use your physics variable to add a force to your player whenever you press your keys
        physics.AddForce(move, ForceMode.Force);

        //Player around with the different forces: Acceleration.Force, ForceMode.VelocityChange, ForceMode.Acceleration, ForceMode.Impulse

    }
}
