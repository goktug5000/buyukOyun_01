using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyNavMeshMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject me, player;
    public NavMeshAgent thisEnemyNavMeshAgent;
    private float distanceLeft;
    void Start()
    {
        me = this.gameObject;
        player = GameObject.Find("Player");
        thisEnemyNavMeshAgent = me.GetComponent<NavMeshAgent>();
    }
    public float getDistanceLeft()
    {
        return distanceLeft;
    }
    // Update is called once per frame
    void Update()
    {
        try
        {
            thisEnemyNavMeshAgent.SetDestination(player.transform.position);
            //Debug.Log(thisEnemyNavMeshAgent.remainingDistance);
            distanceLeft = thisEnemyNavMeshAgent.remainingDistance;
            if (thisEnemyNavMeshAgent.remainingDistance > 15)
            {
                thisEnemyNavMeshAgent.ResetPath();
            }

        }
        catch
        {
            Debug.Log("bi hata var");
        }
        
       
    }
}
