using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Méthode pour charger une scène spécifique
    public static void LoadScene(string sceneName)
    {
        // Charger la scène avec le nom donné
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    // Méthode pour quitter l'application
    public static void QuitGame()
    {
        // Quitter l'application (fonctionne uniquement dans les builds standalone)
        Application.Quit();
    }

    // Méthode pour obtenir la scène active
    public static Scene GetActiveScene()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }
}
