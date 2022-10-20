using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tileEnemy : MonoBehaviour
{

    public string adi;
    public int canavarSaldiriOran, görevOran, itemBulmaOran;
    private float playerLuck;
    public int[][] enemyTypewCount;//xx,yy
    //türü için xx, adeti için yy

    void Start()
    {
        try
        {
            playerLuck = GameObject.Find("Stats").GetComponent<myStats>().luck;
        }
        catch
        {
            Debug.Log("ref için");
        }
        

        canavarSaldiriOran = 0 + canavarSaldiriOran;
        görevOran = canavarSaldiriOran + görevOran;
        itemBulmaOran = görevOran + itemBulmaOran + (int)playerLuck;
        
    }


    private void OnTriggerStay(Collider col)
    {
        int d100 = 0;
        //Debug.Log(col.gameObject.name + " girdi");
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("player girdi ve d100= " + d100);
            d100 = col.gameObject.GetComponent<eventDie>().getD100();
            if(0 <= d100 && d100 <= canavarSaldiriOran)
            {

                //Debug.Log("canavar");
                GameObject.Find("sikenMenejeri").GetComponent<SceneMenejeri>().toFight("", enemyTypewCount);
            }
            else if (canavarSaldiriOran < d100 && d100 <= görevOran)
            {
                //Debug.Log("görev");
            }
            else if (görevOran < d100 && d100 <= itemBulmaOran)
            {
                //Debug.Log("item");
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {

        //Debug.Log(col.gameObject.name + " OnTriggerEnter");

    }

    void Update()
    {
        
    }
}
