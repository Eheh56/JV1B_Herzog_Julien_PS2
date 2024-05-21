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
        if (Input.GetKeyDown(KeyCode.D))
        {
            // D�clenche l'animation "yvesavant"
            animator.SetBool("isMovingForward", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            // Revient � l'animation "yvesnormal"
            animator.SetBool("isMovingForward", false);
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            // D�clenche l'animation "yvesavant"
            animator.SetBool("isMovingBack", true);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            // Revient � l'animation "yvesnormal"
            animator.SetBool("isMovingBack", false);
        }
    }
}