using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class spellsPrepared : MonoBehaviour
{
    [SerializeField] private List<spellSlot> ss;
    [SerializeField] private GameObject thePlayer;
    // Start is called before the first frame update
    public void Awake()
    {
        int prepareLimit=3;
        thePlayer = GameObject.Find("Player");
        try
        {
            prepareLimit = 3 + (int)GameObject.Find("Stats").GetComponent<myStats>().wis;
        }
        catch
        {
            Debug.LogWarning("GameObject.Find(\"Stats\")");

        }
        ss = new List<spellSlot>(prepareLimit);

        for (int i = 0; i < prepareLimit; i++)
        {
            ss.Add(new spellSlot());
        }
    }
    public void SkillGetir()
    {
        int[] n = { 0 };

        ss = this.gameObject.GetComponent<spellSlotHolder>().istedigimiVerr(n);


    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SkillGetir();
        }

    }
}
