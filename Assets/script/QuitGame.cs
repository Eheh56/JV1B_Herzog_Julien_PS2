using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Méthode pour quitter le jeu
    public void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}