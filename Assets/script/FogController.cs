using UnityEngine;

public class FogController : MonoBehaviour
{
    public Transform posA, posB;
    public int Speed;
    Vector2 targetPos;
    private bool canMove = true; // Variable pour indiquer si le brouillard peut se déplacer

    void Start()
    {
        targetPos = posB.position;
    }

    void Update()
    {
        if (canMove)
        {
            if (Vector2.Distance(transform.position, posA.position) < .1f) targetPos = posB.position;

            if (Vector2.Distance(transform.position, posB.position) < .1f) targetPos = posA.position;

            transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
        }
    }

    public void StopMovement()
    {
        canMove = false;
    }
}
