using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    // Cette méthode sera appelée lorsque le bouton sera cliqué
    public void ResetScene()
    {
        // Recharge la scène active
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}