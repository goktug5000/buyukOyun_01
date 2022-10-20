using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plannedFire : MonoBehaviour
{
    public GameObject fireBooo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fireee(GameObject spellObj, Vector3 target)
    {
        
        var mermi = Instantiate(spellObj, target, Quaternion.identity);
        try
        {
            mermi.transform.parent = GameObject.Find("Spells").transform;
        }
        catch
        {
            Debug.LogWarning("abi Spells die bişi yok");
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject spellss = GameObject.Find("Spells");
            fireee(fireBooo, GameObject.Find("aimPoint").transform.position);
        }
    }
}
