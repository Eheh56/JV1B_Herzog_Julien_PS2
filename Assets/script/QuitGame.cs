using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // M�thode pour quitter le jeu
    public void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}