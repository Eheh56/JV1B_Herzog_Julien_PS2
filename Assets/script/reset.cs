using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    void Die(GameObject player)
    {
        Debug.Log("Player is dead!");
        // Logique de mort, par exemple recharger la sc�ne
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Alternativement, tu peux d�sactiver le joueur ou autres objets
        // player.SetActive(false);
    }
}
