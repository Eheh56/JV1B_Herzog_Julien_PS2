using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Animator itemAnimator;

    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            // Arrêter l'animation "lutherexit"
            itemAnimator.SetBool("lutherexit", false);

            // Lancer une fois l'animation "lutherdestroy"
            itemAnimator.SetTrigger("lutherdestroy");

            // Marquer l'item comme collecté
            collected = true;
            
        }
    }
}