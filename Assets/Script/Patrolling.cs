using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrolling : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform[] waypoints;

    int index;

    Vector3 target; 

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            NextWaypoint();
            UpdateWaypoint();
        }
    }

    void UpdateWaypoint()
    {
        target = waypoints[index].position;
        agent.SetDestination(target);
    }

    void NextWaypoint()
    {
        index++;
        if (index == waypoints.Length)
        {
            index = 0;
        }
    }
}
