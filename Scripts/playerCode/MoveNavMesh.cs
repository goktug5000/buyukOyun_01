using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveNavMesh : MonoBehaviour
{
    public Camera mainCam;
    public NavMeshAgent myNavMeshAgent;

    void Start()
    {
        
    }

    public void setSpeed(float mySpeed)
    {
        //Debug.Log("mySpeed: " + mySpeed);
        myNavMeshAgent.speed = mySpeed;
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Ray myRay = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit myHit;
            //Debug.Log(myRay);
            if(Physics.Raycast(myRay, out myHit))
            {
                //Debug.Log("myRay: "+ myRay+ "  myHit.point: "+myHit.point);
                myNavMeshAgent.SetDestination(myHit.point);
            }
        }
    }
}
