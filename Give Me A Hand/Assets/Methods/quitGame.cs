using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class QuitGame
{
    [YarnCommand("quitGame")]
    public static void ExitGame () 
    {
    Application.Quit ();
    Debug.Log("Game is exiting");
    //Just to make sure its working
    }
}
