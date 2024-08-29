using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleTeleporterScript : MonoBehaviour
{
    [Header("Teleporter Control Settings")]
    [Space(25)]
    //We need to create a few variables:

    //This variable will be in charge of whatever object that is being teleported
    public GameObject TeleportThisObject;

    //This will be in charge of the first teleporter in the scene that you will use to link to teleporter 2
    public GameObject Teleport1;

    //This will be in charge of the second teleporter in the scene that you teleport to if the type is SameScene
    public GameObject Teleport2;

    //This variable Enum, will be used to define different label we will use for our next variable
    private enum State { SameScene, NextScene, Retry, None }

    //Lets you view private variables in Unity inspector!
    [SerializeField]
    //This variable will be used to assign our labels and determine which state we are in! 
    private State TeleporterType;

    //This variable calls on the SampleScoreManagerScript, this will allow you to access all pubic components/properties of this script within your current one!
    public SampleScoreManagerScript ScoreManagerScript;

    //This will be the value needed to activate teleporter
    public int PointsNeeded;

    private void OnTriggerEnter(Collider other)
    {
        //Switch statement is different from if statement, this allows you to compare one variable to mutliple conditions like branches! 
        switch (TeleporterType)
        {
            //In the case if the label in Same Scene
            case State.SameScene:
                //If teleporter is touched by player and Teleporter 1 is active
                if (other.gameObject.tag == "Player" && Teleport1.active)
                {
                    //Set the player postion to equal Teleporter 2!
                    other.gameObject.transform.position = Teleport2.transform.position;
                }
                break;
            //In the case if the label in Same Scene
            case State.NextScene:
                //If teleporter is touched by player and Teleporter 1 is active
                if (other.gameObject.tag == "Player" && Teleport1.active)
                {
                    //Load the next scene within the Build settings after the current scene, exp: If the scene we are in has a index/number of 0, then go to the next one after it!
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                break;
            //In the case if the label in Same Scene
            case State.Retry:
                //If teleporter is touched by player and Teleporter 1 is active
                if (other.gameObject.tag == "Player" && Teleport1.active)
                {
                    //Load The Same Scene
                    SceneManager.LoadScene(0);
                }
                break;
            //In the case if the label in None 
            case State.None:
                //Do nothing
                    return;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PointsNeeded == ScoreManagerScript.scoreValue)
        {
            this.Teleport1.SetActive(true);
        }
    }
}
