using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrullajeManager : MonoBehaviour
{
    public Transform target0;
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = target0.position;
    }
}
