using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // M�thode appel�e lorsqu'un bouton est cliqu�
    public void LoadLevel(string levelName)
    {
        // Charger le niveau correspondant au nom sp�cifi�
        SceneManager.LoadScene(levelName);
    }
}
