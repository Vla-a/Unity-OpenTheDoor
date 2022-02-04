using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMove : MonoBehaviour
{
    private NavMeshAgent agent;  
    [SerializeField] private GameObject play;   

    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = play.transform.position;    
         
    }


}
