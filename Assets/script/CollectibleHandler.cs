using UnityEngine;

public class CollectibleHandler : MonoBehaviour
{
    private Animator animator;
    private bool isCollected = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;
            animator.SetTrigger("StartCollected");
            // Désactiver le collectable après l'animation
            Invoke("DisableCollectible", 1.7f); // Remplacer 1.0f par la durée réelle de l'animation "luther"
        }
    }

    void DisableCollectible()
    {
        gameObject.SetActive(false);
    }
}
