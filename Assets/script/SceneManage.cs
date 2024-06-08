using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Méthode pour charger une scène spécifique
    public void LoadScene(string sceneName)
    {
        // Charger la scène avec le nom donné
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    // Méthode pour quitter l'application
    public void QuitGame()
    {
        // Quitter l'application (fonctionne uniquement dans les builds standalone)
        Application.Quit();
    }
}
