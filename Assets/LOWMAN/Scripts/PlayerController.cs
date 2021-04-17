using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   //INCLUDE Using UnityEngine.AI to reference agent
using UnityStandardAssets.Characters.ThirdPerson; // INCLUDE for changing third person char animation


public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;


    private void Start()
    {
        cam = Camera.main;
        agent.updateRotation = false;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;

         if (Physics.Raycast(ray, out hit))
         {
                // MOVE OUR AGENT

                agent.SetDestination(hit.point);
         }
        }

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
        
    }
}
