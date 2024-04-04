using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAnimatorManager : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Velocity",navMeshAgent.velocity.magnitude);
    }
}
