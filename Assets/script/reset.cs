using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    void Die(GameObject player)
    {
        Debug.Log("Player is dead!");
        // Logique de mort, par exemple recharger la scène
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Alternativement, tu peux désactiver le joueur ou autres objets
        // player.SetActive(false);
    }
}
