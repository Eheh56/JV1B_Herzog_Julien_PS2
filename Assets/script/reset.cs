using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    // Cette m�thode sera appel�e lorsque le bouton sera cliqu�
    public void ResetScene()
    {
        // Recharge la sc�ne active
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}