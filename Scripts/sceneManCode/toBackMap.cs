using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toBackMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void donArtik()
    {
        GameObject.Find("sikenMenejeri").GetComponent<SceneMenejeri>().toSample();
    }

}
