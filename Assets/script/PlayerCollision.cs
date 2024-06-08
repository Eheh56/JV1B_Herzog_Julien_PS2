using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("objectYves"))
        {
            FogController fogController = FindObjectOfType<FogController>();
            if (fogController != null)
            {
                fogController.StopMovement();
            }
        }
    }
}
