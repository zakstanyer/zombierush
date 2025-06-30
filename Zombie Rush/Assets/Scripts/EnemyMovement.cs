using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(agent.transform.position, player.transform.position) < 8)
        {
            MoveToPlayer();
        }
    }

    private void MoveToPlayer()
    {
        agent.destination = player.transform.position;
    }
}
