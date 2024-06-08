using UnityEngine;

public class LevelSelectorInput : MonoBehaviour
{
    public GameObject levelSelectorCanvas; // R�f�rence au Canvas contenant les boutons de s�lection de niveau

    void Update()
    {
        // Ouvrir le s�lecteur de niveau lorsque la touche "L" est enfonc�e
        if (Input.GetKeyDown(KeyCode.L))
        {
            levelSelectorCanvas.SetActive(true);
        }
        // Fermer le s�lecteur de niveau lorsque la touche "L" est rel�ch�e
        else if (Input.GetKeyUp(KeyCode.L))
        {
            levelSelectorCanvas.SetActive(false);
        }
    }
}
