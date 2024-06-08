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
        // Rechercher livesText si non assigné
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
            // Réinitialiser le compteur de morts avant de charger la scène Game Over
            deathCount = 0;
            // Charger la scène Game Over
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            // Réinitialiser le niveau
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PlayerDied()
    {
        deathCount++;
        UpdateLivesText();

        if (deathCount >= maxDeaths)
        {
            // Charger la scène Game Over
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            // Réinitialiser le niveau
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Autres méthodes du script...
}
