using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] Waypoints; 
    public float Speed; 
    public int curWaypoint; 
    public bool Patrol = true; 
    public Vector3 Target; 
    public Vector3 MoveDirection; 
    public Vector3 Velocity; 

    private Rigidbody rb;

    void Start()
    {
        curWaypoint = 0;

        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing from the game object.");
            return;
        }

        rb.isKinematic = false;
    }

    void Update()
    {
        if (rb == null) return; // Ensure Rigidbody is present

        if (curWaypoint < Waypoints.Length)
        {
            Target = Waypoints[curWaypoint].position; 
            MoveDirection = Target - transform.position; 
            Velocity = rb.velocity; 

            if (MoveDirection.magnitude < 1.0f)
            {
                curWaypoint++;
            }
            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }
        else
        {
            if (Patrol)
            {
                curWaypoint = 0;
            }
            else
            {
                Velocity = Vector3.zero;
            }
        }

        rb.velocity = Velocity;

        transform.Rotate(new Vector3(0, 300, 0) * Time.deltaTime);
    }
}
