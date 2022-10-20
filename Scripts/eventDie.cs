using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventDie : MonoBehaviour
{
    private float cd = 8;
    private int d20, d100;
    // Start is called before the first frame update
    void Start()
    {
        d100 = Random.Range(0, 101);
    }

    // Update is called once per frame
    void Update()
    {
        cd -= 1 * Time.deltaTime;
        if (cd <= 0)
        {
            cd = 8;
            d100 = Random.Range(0, 101);
        }

    }
    public int getD100()
    {
        return d100;
    }
}
