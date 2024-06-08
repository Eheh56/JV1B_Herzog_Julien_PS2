using UnityEngine;

public class LevelSelectorInput : MonoBehaviour
{
    public GameObject levelSelectorCanvas; // Référence au Canvas contenant les boutons de sélection de niveau

    void Update()
    {
        // Ouvrir le sélecteur de niveau lorsque la touche "L" est enfoncée
        if (Input.GetKeyDown(KeyCode.L))
        {
            levelSelectorCanvas.SetActive(true);
        }
        // Fermer le sélecteur de niveau lorsque la touche "L" est relâchée
        else if (Input.GetKeyUp(KeyCode.L))
        {
            levelSelectorCanvas.SetActive(false);
        }
    }
}
