using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public Sprite devant;
    public Sprite derriere;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        animator.SetBool("isMovingForward", rb.velocity.x != 0);
        if(rb.velocity.x > 0) { GetComponent<Transform>().localScale = new Vector2(1, 1);}
        else if(rb.velocity.x < 0) { GetComponent<Transform>().localScale = new Vector2(-1, 1);}
    }
}