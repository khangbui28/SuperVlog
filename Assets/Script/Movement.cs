using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{

    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray movePos = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit; 

            if (Physics.Raycast(movePos, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
