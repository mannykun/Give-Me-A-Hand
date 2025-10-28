using UnityEngine;
using UnityEngine.UI;
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
        StartButton.gameObject.SetActive(false);
        MoveQuitButtonToTopRight();
        dialogueRunner.StartDialogue("Start");
    }

    void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void MoveQuitButtonToTopRight()
    {
        var rt = QuitButton.GetComponent<RectTransform>();
        if (rt == null) return;
        rt.anchorMin = new Vector2(1f, 1f);
        rt.anchorMax = new Vector2(1f, 1f);
        rt.pivot = new Vector2(1f, 1f);
        rt.anchoredPosition = new Vector2(-20f, -20f);
        QuitButton.interactable = true;
        QuitButton.gameObject.SetActive(true);
    }
}