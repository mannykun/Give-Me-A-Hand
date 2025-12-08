using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;
    public Button CreditsButton;
    public Button BackButton;

    public GameObject CreditsPanel;

    public DialogueRunner dialogueRunner;

    void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        QuitButton.onClick.AddListener(QuitGame);
        CreditsButton.onClick.AddListener(OpenCredits);
        BackButton.onClick.AddListener(CloseCredits);
            CreditsPanel.SetActive(false);

    }

    void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(false);
        CreditsButton.gameObject.SetActive(false);

        dialogueRunner.StartDialogue("Start");
    }

    void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void OpenCredits()
    {
        CreditsPanel.SetActive(true); 
    }
    
    void CloseCredits()
    {
        CreditsPanel.SetActive(false);
    }

}