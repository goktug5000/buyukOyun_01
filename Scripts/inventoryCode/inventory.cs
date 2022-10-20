using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject invP,spellP;
    // Start is called before the first frame update
    void Start()
    {
        invP.SetActive(false);
        spellP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            try
            {
                invP.SetActive(!invP.active);

                spellP.SetActive(false);
            }
            catch
            {

            }
            
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            try
            {
                invP.SetActive(false);

                spellP.SetActive(!spellP.active);
                
            }
            catch
            {

            }

        }
    }
}
