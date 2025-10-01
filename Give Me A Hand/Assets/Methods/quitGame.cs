using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class quitGame
{
    [YarnCommand("quitGame")]
    void QuitGame () 
    {
    Application.Quit ();
    Debug.Log("Game is exiting");
    //Just to make sure its working
    }
}
