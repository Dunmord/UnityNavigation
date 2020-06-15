using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentController : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;
    private void Awake()
    {
        if (!agent)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }
    private void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
