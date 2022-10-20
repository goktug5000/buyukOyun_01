using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class myStats : MonoBehaviour
{
    public float maxHp;
    public float maxMana;
    public float str;
    public float con;
    public float agi;
    public float luck;
    public float wis;
    public float intelligence;
    public float chr;
    public GameObject player;

    //public itemFight[] keybindOne, keybindTwo, keybindThree;

    void Start()
    {
        str = 3;
        con = 3;
        agi = 3;
        luck = 3;
        wis = 3;
        intelligence = 3;
        chr = 3;

        maxHp = 10 + con;
        maxMana = 0 + wis*2;

        try
        {
            player = GameObject.Find("Player");
            player.GetComponent<MoveNavMesh>().setSpeed(2 + agi / 2);
        }
        catch
        {

        }

    }

    public void reStatHero()
    {

        try
        {
            player = GameObject.Find("Player");
            player.GetComponent<MoveNavMesh>().setSpeed(2 + agi / 2);
        }
        catch
        {

        }
        
    }
    

    void Update()
    {
        
        
    }
}
