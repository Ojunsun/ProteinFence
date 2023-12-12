using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent _naveAgent;

    private void Awake()
    {
        _naveAgent = GetComponent<NavMeshAgent>();
    }

    public void SetSpeed(float speed)
    {
        _naveAgent.speed = speed;
    }

    public void MoveToTarget(Vector3 target)
    {
        _naveAgent.SetDestination(target);
    }
}
