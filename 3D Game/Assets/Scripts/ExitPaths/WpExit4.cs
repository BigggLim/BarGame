using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpExit4 : MonoBehaviour
{
    // Stores a Referemce to the waypoint system this object will use
    [SerializeField] public WpLeave4 waypoints;
    public bool leave;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float distanceThreshold = 0.1f;
    public Transform currentWaypoint;



    // Start is called before the first frame update
    void Start()
    {
        leave = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (leave == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
                transform.LookAt(currentWaypoint);
            }
        }


    }

    void UpdateLeave()
    {
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;
        leave = true;


    }
}
