using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleFollowScript : MonoBehaviour
{
    // We must create 5 variables!
    //1 variable that will be an array of cameras that we can switch to within our game
    //3 KeyCode variables that will our keybinds for each specific camera we can switch to
    //1 variable that will be incharge of what the camera is following 

    [Header("Camera Control Settings")]
    public Camera[] CameraList;

    [Header("Keybinds for Cameras")]
    
    [SerializeField]
    private KeyCode Camera1;
    [SerializeField]
    private KeyCode Camera2;
    [SerializeField]
    private KeyCode Camera3;

    [Space(5)]
    public GameObject FollowThisObject;
    private void Awake()
    {
        //Make sure to put All CameraList[].gameObjects here
        //and set the 2nd and 3rd camera to be false,
        //and leave the first camera active at the start
        CameraList[0].gameObject.SetActive(true);
        CameraList[1].gameObject.SetActive(false);
        CameraList[2].gameObject.SetActive(false);
    }

    private void Update()
    {
        //If I press the Camera 1 button (Number 1 Key)
        if (Input.GetKeyDown(Camera1))
        {           
            //Turn all Cameras to off except for the Main Camera
            CameraList[0].gameObject.SetActive(true);
            CameraList[1].gameObject.SetActive(false);
            CameraList[2].gameObject.SetActive(false);

        }
        //If I press the Camera 1 button (Number 2 Key)
        if (Input.GetKeyDown(Camera2))
        {
            //Turn all Cameras to off except for the Camera View 2
            CameraList[0].gameObject.SetActive(false);
            CameraList[1].gameObject.SetActive(true);
            CameraList[2].gameObject.SetActive(false);
        }

        //If I press the Camera 1 button (Number 3 Key)
        if (Input.GetKeyDown(Camera3))
        {
            //Turn all Cameras to off except for the Camera View 3
            CameraList[0].gameObject.SetActive(false);
            CameraList[1].gameObject.SetActive(false);
            CameraList[2].gameObject.SetActive(true);
        }

        //For loop that will run through the entire list
        for (int index = 0; index < CameraList.Length; index++)
        {
            //Set all cameras with in the list to follow the player
            CameraList[index].transform.LookAt(FollowThisObject.transform);
        }
    }
}