using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // R�f�rence au joueur
    public Vector3 offset;   // D�calage entre la cam�ra et le joueur

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
            // Mettre � jour la position de la cam�ra en fonction de celle du joueur
            transform.position = player.position + offset;
        }
    }
}