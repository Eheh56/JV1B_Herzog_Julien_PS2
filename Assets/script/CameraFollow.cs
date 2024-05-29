using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Référence au joueur
    public Vector3 offset;   // Décalage entre la caméra et le joueur

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player transform is not assigned in the CameraFollow script.");
        }
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Mettre à jour la position de la caméra en fonction de celle du joueur
            transform.position = player.position + offset;
        }
    }
}