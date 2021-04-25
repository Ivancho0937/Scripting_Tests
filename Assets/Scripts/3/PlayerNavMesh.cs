using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerNavMesh : MonoBehaviour
{

    public Camera camaraP;
    public NavMeshAgent agent;
    //public Animator anim;
    



   // RaycastHit hitInfo = new RaycastHit();

    


    void Start()
    {
       // anim = GetComponent<Animator>();
       

    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camaraP.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                //move agent

                if (hit.collider.tag == "Enemy")
                {
                    agent.SetDestination(agent.pathEndPosition);
                    
                }
                else
                {
                    agent.SetDestination(hit.point);
                }

            }
           





        }

        
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
                agent.destination = hitInfo.point;
        }

        */
       

    }
}
