using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    private static int deathCount = 0;  // Variable statique pour conserver le compteur de morts
    private const int maxDeaths = 15;
    private static LifeManager instance;

    void Awake()
    {
        // Assurer qu'il n'y a qu'un seul LifeManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Rechercher livesText si non assign�
        if (livesText == null)
        {
            livesText = FindObjectOfType<TextMeshProUGUI>();

            if (livesText == null)
            {
                Debug.LogError("LivesText is not assigned and cannot be found in the scene.");
            }
        }

        // Initialiser l'affichage des vies
        UpdateLivesText();
    }

    private void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Vies restantes : " + (maxDeaths - deathCount);
        }
        else
        {
            Debug.LogError("LivesText is not assigned in the inspector.");
        }
    }

    public void PlayerDead()
    {
        deathCount++;
        UpdateLivesText();

        if (deathCount >= maxDeaths)
        {
            // R�initialiser le compteur de morts avant de charger la sc�ne Game Over
            deathCount = 0;
            // Charger la sc�ne Game Over
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            // R�initialiser le niveau
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PlayerDied()
    {
        deathCount++;
        UpdateLivesText();

        if (deathCount >= maxDeaths)
        {
            // Charger la sc�ne Game Over
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            // R�initialiser le niveau
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Autres m�thodes du script...
}
