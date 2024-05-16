using UnityEngine;

public class HorizontalCameraFollow : MonoBehaviour
{
    public Transform target; // Le transform du personnage � suivre
    public float smoothSpeed = 0.125f; // La vitesse de d�placement de la cam�ra

    void FixedUpdate()
    {
        // D�placer la position de la cam�ra horizontalement pour suivre le personnage
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
} //test