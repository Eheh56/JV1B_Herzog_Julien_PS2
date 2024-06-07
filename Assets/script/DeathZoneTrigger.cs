using UnityEngine;

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

        PlayerLives playerLives = player.GetComponent<PlayerLives>();
        if (playerLives != null)
        {
            playerLives.LoseLife();
        }
    }
}
