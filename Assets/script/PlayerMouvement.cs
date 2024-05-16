using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement horizontal
    public float jumpForce = 10f; // Force du saut
    public int maxJumps = 2; // Nombre maximum de sauts
    private int jumpsRemaining; // Nombre de sauts restants

    private Rigidbody2D rb;
    private bool isGrounded;

    public Transform groundCheck; // Référence à un objet vide placé sous les pieds du personnage
    public LayerMask groundLayer; // Masque de collision pour déterminer si le personnage est au sol

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsRemaining = maxJumps;
    }

    void Update()
    {
        // Vérifier si le personnage est au sol en lançant un rayon vers le bas
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Si le joueur touche le sol, réinitialiser les sauts restants
        if (isGrounded)
        {
            jumpsRemaining = maxJumps;
        }

        // Déplacement horizontal
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Saut (en utilisant la touche d'espace) si des sauts restants
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpsRemaining--;
        }
    }
}