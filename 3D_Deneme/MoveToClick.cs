//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

//Basic movement script.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToPosition();
        }
    }
    private void MoveToPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit))        //If hit an object, our player will start at that point.
        {
            navMeshAgent.SetDestination(hit.point);
        }
    }
}
