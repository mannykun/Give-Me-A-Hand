using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;
    public DialogueRunner dialogueRunner;

    void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        QuitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        dialogueRunner.StartDialogue("Start");
    }

    void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}