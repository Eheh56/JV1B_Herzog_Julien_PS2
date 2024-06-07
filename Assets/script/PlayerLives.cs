using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerLives : MonoBehaviour
{
    public static PlayerLives instance;

    public int lives = 10;
    public string gameOverSceneName = "GameOver";
    public TextMeshProUGUI livesText;
    public Transform respawnPoint;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateLivesText();
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
        if (respawnPoint != null)
        {
            Transform playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            playerTransform.position = respawnPoint.position;
        }
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesText();

        if (lives <= 0)
        {
            GameOver();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(gameOverSceneName);
    }

    public void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }
}
