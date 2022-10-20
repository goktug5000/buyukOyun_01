using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class spellSlot
{
    [SerializeField] private spell mySpell;

    public spell MySpell => mySpell;


    public spellSlot(spell mSpell)
    {
        mySpell = mSpell;
    }
    public spellSlot()
    {
        ClearSlot();
    }

    public void ClearSlot()
    {
        mySpell = null;
    }
}
