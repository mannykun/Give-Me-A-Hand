using UnityEngine;
using Yarn.Unity;
using System.Collections;

public class DialogueStarter : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public float delay = 1f;
    private bool hasStarted = false;

    void OnEnable()
    {
        StartCoroutine(WaitAndStart());
    }

    IEnumerator WaitAndStart()
    {
        yield return new WaitForSeconds(delay);
        if (!hasStarted && dialogueRunner != null)
        {
            hasStarted = true;
            dialogueRunner.StartDialogue("Start");
        }
    }
}