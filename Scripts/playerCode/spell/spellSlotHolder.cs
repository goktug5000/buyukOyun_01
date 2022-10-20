using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class spellSlotHolder : MonoBehaviour
{
    [SerializeField] private int spellSize;
    [SerializeField] protected spellSystem spellSystemm;
    [SerializeField] private List<spellSlot> mySpells;
    public GameObject biSpellSlot;
    public spellSystem InventorySystem => spellSystemm;

    private void Awake()
    {
        spellSystemm = new spellSystem(spellSize);
    }
    public List<spellSlot> istedigimiVerr(int[] n)
    {
        List<spellSlot> a = new List<spellSlot>();
        a = spellSystemm.istedigimiVer(n);
        return a;
    }
    public void spellPanelGuncelle()
    {
        GameObject spellPanel = GameObject.Find("KaydirBunu");
        GameObject biSi = Instantiate(biSpellSlot, transform.position, transform.rotation) as GameObject;
        try
        {
            biSi.transform.parent = spellPanel.transform;
        }
        catch
        {
            Debug.LogWarning("abi spellPanel die bişi yok");
        }
        int[] a = { 0 };
        mySpells = new List<spellSlot>();
        mySpells = istedigimiVerr(a);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spellPanelGuncelle();
        }

    }
}
