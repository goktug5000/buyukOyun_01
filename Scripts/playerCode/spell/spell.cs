using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Prefabs / Spells")]


public class spell : ScriptableObject
{
    public Sprite icon;
    public int id;
    public string namee;
    [TextArea(5, 5)]
    public string aciklama;

    /*
    public enum tipi
    {
        fiziki,
        firlatma,
        buyulu,
        iyilestirme,
        olusturma
    }
    */
    public float menzili,menzilCarpani;
    public float hasari,hasarCarpani;
    public float hasarAlani;
    public float cd,cdCarpani;
    public float manaBedeli,manaBedeliCarpani;
    public int spellLvl;
}
