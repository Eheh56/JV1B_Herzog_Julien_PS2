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
            // Déclenche l'animation "yvesavant"
            animator.SetBool("isMovingForward", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            // Revient à l'animation "yvesnormal"
            animator.SetBool("isMovingForward", false);
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            // Déclenche l'animation "yvesavant"
            animator.SetBool("isMovingBack", true);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            // Revient à l'animation "yvesnormal"
            animator.SetBool("isMovingBack", false);
        }
    }
}