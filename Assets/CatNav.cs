using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatNav : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject point;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = point.transform.position;
    }


}
