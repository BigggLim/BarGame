using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpLeave4 : MonoBehaviour
{
    [Range(0f, 2f)]
    [SerializeField] private float waypointSize = 1f;

    private void OnDrawGizmos()
    {

        foreach (Transform t in transform)
        {
            Gizmos.color = Color.grey;
            Gizmos.DrawWireSphere(t.position, waypointSize);
        }

        Gizmos.color = Color.magenta;
        for (int i = 0; i < transform.childCount - 1; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }
    }


    public Transform GetNextWaypoint(Transform currentWaypoint)
    {


        if (currentWaypoint == null)
        {
            return transform.GetChild(0);

        }
        if (currentWaypoint.GetSiblingIndex() < transform.childCount - 1)
        {
            return transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);
        }
        else
        {
            return transform.GetChild(7);
        }



    }
}
