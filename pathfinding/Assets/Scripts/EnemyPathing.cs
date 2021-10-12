using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPathing : MonoBehaviour
{
    // The player object and the navMeshAgent component
    GameObject player;
    NavMeshAgent navMeshAgent;

    void Start()
    {
        // Assign the variables
        player = GameObject.Find("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navMeshAgent.destination = player.transform.position;
    }
}