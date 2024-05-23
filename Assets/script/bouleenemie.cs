using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouleenemie : MonoBehaviour
{
    public Transform posA, posB, posC, posD;
    public int Speed;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = posA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f) targetPos = posB.position;

        if (Vector2.Distance(transform.position, posB.position) < .1f) targetPos = posC.position;

        if (Vector2.Distance(transform.position, posC.position) < .1f) targetPos = posD.position;

        if (Vector2.Distance(transform.position, posD.position) < .1f) targetPos = posA.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);

    }









    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(posA.position, posB.position);
        Gizmos.DrawLine(posB.position, posC.position);
        Gizmos.DrawLine(posC.position, posD.position);
        Gizmos.DrawLine(posD.position, posA.position);
    }
}
