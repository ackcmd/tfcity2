using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveNavmesh : MonoBehaviour {
    Animator animator;
    Vector3 nextPosition;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        animator = GameObject.FindObjectOfType<Animator>();
        nextPosition = transform.position;
        animator.SetBool("param_toidle", true);
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            //animator.SetTrigger("trigger_idletohit03");

        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "terrain")
                {
                    nextPosition = hit.point;
                    animator.SetBool("param_toidle", false);
                    animator.SetBool("param_idletorunning", true);
                }

                if (hit.transform.parent.tag == "building")
                {
                    //hit.transform.parent.GetComponent
                }

                if (hit.transform.parent.tag == "building")
                {
                    //hit.transform.GetComponent
                }
            }
        }
        //transform.LookAt(nextPosition);
        //transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * 6f);
        agent.SetDestination(nextPosition);
        agent.isStopped = false;
        agent.updateRotation = true;
        agent.updatePosition = true;

        if (Vector3.Distance (nextPosition, transform.position) < 0.2f)
        {
            //nextPosition = transform.position;
            //Debug.Log("Destination reached");
            animator.SetBool("param_idletorunning", false);
            animator.SetBool("param_toidle", true);
            agent.isStopped = true;
            agent.updateRotation = false;
            agent.updatePosition = false;
            //agent.ResetPath();
        }
    }
}
