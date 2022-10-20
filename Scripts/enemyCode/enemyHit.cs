using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour
{
    public float attackDMG;
    public float attackCDmax;
    public float attackDistance;
    private float attackCD;
    public GameObject hitBox;
    // Start is called before the first frame update
    void Start()
    {
        hitBox.SetActive(false);
        attackCD = attackCDmax;
    }
    public void attack()
    {
        if(this.gameObject.GetComponent<enemyNavMeshMove>().getDistanceLeft()<= attackDistance)
        {
            //Debug.Log("enemyHit");
            hitBox.SetActive(true);
            attackCD = attackCDmax;
            
        }
        
        
    }
    // Update is called once per frame
    void Update()
    {
        if(attackCD <= attackCDmax - 1)
        {
            hitBox.SetActive(false);
        }
        if(attackCD > 0)
        {
            attackCD -= Time.deltaTime;
        }
        else if (attackCD <= 0)
        {
            attack();
        }
    }
}
