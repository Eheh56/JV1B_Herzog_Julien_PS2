using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Start()
    {
        AssignLivesText();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AssignLivesText();
    }

    private void AssignLivesText()
    {
        if (PlayerLives.instance != null && livesText != null)
        {
            PlayerLives.instance.livesText = livesText;
            PlayerLives.instance.UpdateLivesText();
        }
    }
}
