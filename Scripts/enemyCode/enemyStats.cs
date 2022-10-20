using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public string name;

    public float Hp;
    public float Mana;

    public float str;
    public float con;
    public float agi;
    public float luck;
    public float wis;
    public float intelligence;
    public float chr;

    public int[][] loot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDMG(float dmg)
    {
        Hp -= dmg;
        if (Hp <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
