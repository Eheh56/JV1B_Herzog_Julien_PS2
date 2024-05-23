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
            // D�sactiver le collectable apr�s l'animation
            Invoke("DisableCollectible", 1.7f); // Remplacer 1.0f par la dur�e r�elle de l'animation "luther"
        }
    }

    void DisableCollectible()
    {
        gameObject.SetActive(false);
    }
}
