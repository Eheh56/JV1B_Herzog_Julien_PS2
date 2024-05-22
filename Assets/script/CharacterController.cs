using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Gérer l'animation pour la touche "D"
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isMovingForward", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isMovingForward", false);
        }

        // Gérer l'animation pour la touche "Q"
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isMovingBackward", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isMovingBackward", false);
        }
    }
}