using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // M�thode pour charger une sc�ne sp�cifique
    public static void LoadScene(string sceneName)
    {
        // Charger la sc�ne avec le nom donn�
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    // M�thode pour quitter l'application
    public static void QuitGame()
    {
        // Quitter l'application (fonctionne uniquement dans les builds standalone)
        Application.Quit();
    }

    // M�thode pour obtenir la sc�ne active
    public static Scene GetActiveScene()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }
}
