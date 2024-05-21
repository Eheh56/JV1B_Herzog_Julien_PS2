using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZoneTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Die(other.gameObject);
        }
    }

    void Die(GameObject player)
    {
        Debug.Log("Player is dead!");
        // Logique de mort, par exemple recharger la scène
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Alternativement, tu peux désactiver le joueur ou autres objets
        // player.SetActive(false);
    }
}
