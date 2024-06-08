using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Méthode appelée lorsqu'un bouton est cliqué
    public void LoadLevel(string levelName)
    {
        // Charger le niveau correspondant au nom spécifié
        SceneManager.LoadScene(levelName);
    }
}
