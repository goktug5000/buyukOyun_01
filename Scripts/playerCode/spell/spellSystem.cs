using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class spellSystem
{
    [SerializeField] private List<spellSlot> spellSlots;

    public List<spellSlot> SpellSlots => SpellSlots;

    public int SpellSize => spellSlots.Count;

    public spellSystem(int size)        //wis den gelicek
    {
        spellSlots = new List<spellSlot>(size);
        for (int i = 0; i < size; i++)
        {
            spellSlots.Add(new spellSlot());
        }
    }
    public List<spellSlot> istedigimiVer(int[] n)
    {
        List<spellSlot> a = new List<spellSlot>();
        //Debug.Log("ekledim: " + spellSlots[0].MySpell + spellSlots[1].MySpell + spellSlots[2].MySpell);
        int x = 0;
        foreach(int nn in n)
        {
            try
            {
                a.Add(spellSlots[x]);
                x++;
            }
            catch
            {

            }
        }

        //a.Add(spellSlots[1]);
        //a.Add(spellSlots[2]);


        return a;
    }
}
