using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // M�thode pour charger une sc�ne sp�cifique
    public void LoadScene(string sceneName)
    {
        // Charger la sc�ne avec le nom donn�
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    // M�thode pour quitter l'application
    public void QuitGame()
    {
        // Quitter l'application (fonctionne uniquement dans les builds standalone)
        Application.Quit();
    }
}
