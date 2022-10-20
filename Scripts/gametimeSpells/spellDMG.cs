using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellDMG : MonoBehaviour
{
    public float timee;
    public bool tekKezVur;
    public float dmg;
    public float dmgByTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (tekKezVur == true)
        {
            if(other.gameObject.GetComponent<enemyStats>() != null)
            {

                other.gameObject.GetComponent<enemyStats>().takeDMG(dmg);
                Destroy(this.gameObject);
            }
            
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<enemyStats>() != null)
        {

            other.gameObject.GetComponent<enemyStats>().takeDMG(dmgByTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tekKezVur == false)
        {
            timee -= 1 * Time.deltaTime;
            if (timee <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
