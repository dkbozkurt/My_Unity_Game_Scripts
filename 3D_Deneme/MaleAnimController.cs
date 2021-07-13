//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

// IDLE - Walk transition animation script.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MaleAnimController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("PlayerVelocity", navMeshAgent.velocity.magnitude);
        Debug.Log(navMeshAgent.velocity.magnitude);

    }
}
