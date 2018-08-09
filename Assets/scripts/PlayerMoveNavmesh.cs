using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerMoveNavmesh : MonoBehaviour {
    Animator animator;
    Vector3 nextPosition;
    NavMeshAgent agent;
    RaycastHit hit = new RaycastHit();
    string objectName;

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

        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "terrain")
                {
                    nextPosition = hit.point;
                    animator.SetBool("param_toidle", false);
                    animator.SetBool("param_idletorunning", true);
                    Debug.Log(nextPosition);
                }

                if (hit.transform.parent!= null)
                {
                    if (hit.transform.parent.tag == "building")
                    {
                        nextPosition = hit.transform.parent.GetComponent<BuildingData>().entrance;
                        animator.SetBool("param_toidle", false);
                        animator.SetBool("param_idletorunning", true);
                    }

                }

                if (hit.transform.tag == "building")
                {
                    nextPosition = hit.transform.GetComponent<BuildingData>().entrance;
                    animator.SetBool("param_toidle", false);
                    animator.SetBool("param_idletorunning", true);
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
            objectName = null;
            if (hit.transform != null)
            {
                if (hit.transform.tag == "building")
                {
                    Debug.Log("Entering Building: " + hit.transform.name);
                    objectName = hit.transform.name;
                }
                if (hit.transform.parent != null)
                {
                    if (hit.transform.parent.tag == "building")
                    {
                        Debug.Log("Entering Building: " + hit.transform.parent.name);
                        objectName = hit.transform.parent.name;
                    }

                }
                hit = new RaycastHit();
                if (objectName != null) EventManager.TriggerEvent(objectName);
            }


        }
    }
}
