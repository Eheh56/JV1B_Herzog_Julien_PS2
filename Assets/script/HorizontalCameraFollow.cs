using UnityEngine;

public class HorizontalCameraFollow : MonoBehaviour
{
    public Transform target; // Le transform du personnage à suivre
    public float smoothSpeed = 0.125f; // La vitesse de déplacement de la caméra

    void FixedUpdate()
    {
        // Déplacer la position de la caméra horizontalement pour suivre le personnage
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
} //test