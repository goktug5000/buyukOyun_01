using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectHalf : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        int xxx = 0;
        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObj.name == this.gameObject.name.ToString())
            {
                xxx++;
            }
        }
        
        if (xxx != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

}
