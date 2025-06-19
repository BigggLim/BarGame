using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    // Stores a Referemce to the waypoint system this object will use
    [SerializeField] public Waypoints waypoints;
    public bool move;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float distanceThreshold = 0.1f;
    public Transform currentWaypoint;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        move = true;
        //Set initial postion to the first waypoint
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;
        transform.LookAt(currentWaypoint);


    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
                transform.LookAt(currentWaypoint);
            }

        }

    }

    void MoveUpdate()
    {
        move = false;
    }
}
