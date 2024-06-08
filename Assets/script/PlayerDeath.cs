using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private LifeManager lifeManager;

    void Start()
    {
        // Trouver le gestionnaire de vie dans la sc�ne
        lifeManager = FindObjectOfType<LifeManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // V�rifier si l'objet qui entre en contact est le joueur
        if (collision.gameObject.CompareTag("Player"))
        {
            // Informer le gestionnaire de vie que le joueur est mort
            lifeManager.PlayerDied();
        }
    }
}
