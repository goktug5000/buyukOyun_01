using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDokunulmazlik : MonoBehaviour
{
    // Start is called before the first frame update
    public float dokunulmazlik;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dokunulmazlik > 0)
        {
            dokunulmazlik -= Time.deltaTime;
        }
    }
}
