using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Yarn.Unity;


public class Quit
{
    [YarnCommand("quitGame")]
    public static void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}

public class Music
{
    [YarnCommand("musicOn")]
    public static void MusicOn(AudioSource music)
    {
        music.Play();
        Debug.Log("Playing " + music.name);
    }

    [YarnCommand("musicOff")]
    public static void MusicOff(AudioSource music)
    {
        music.Stop();
        Debug.Log("Stopping " + music.name);
    }
}

public class Location
{
    static SpriteRenderer currentLocation;

    [YarnCommand("Swap")]
    public static void Swap(GameObject Location)
    {
        if (Location != null)
        {
            SpriteRenderer locationSprite = Location.GetComponent<SpriteRenderer>();
            SpriteRenderer lastLocation;


            lastLocation = currentLocation;
            currentLocation = locationSprite;
            currentLocation.enabled = true;
            Debug.Log(Location + " is now active");
            if (lastLocation != null)
            {
                lastLocation.enabled = false;
                Debug.Log(lastLocation + " is no longer active");
            }
        }
        else Debug.LogWarning("GameObject not found for command 'Swap'.");
    }
}

public class Animation
{
    static SpriteRenderer currentEmotion;
    
    [YarnCommand("Animate")]
    public static void Animate(GameObject Emotion)
    {
        if (Emotion != null)
        {
            SpriteRenderer emotionSprite = Emotion.GetComponent<SpriteRenderer>();
            SpriteRenderer lastEmotion;


            lastEmotion = currentEmotion;
            currentEmotion = emotionSprite;
            currentEmotion.enabled = true;
            Debug.Log(Emotion + " is now active");
            if (lastEmotion != null)
            {
                lastEmotion.enabled = false;
                Debug.Log(lastEmotion + " is no longer active");
            }
        }
        else Debug.LogWarning("GameObject not found for command 'Animate'.");
    }
}
