using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prefabs/Items")]
public class itemFight : ScriptableObject
{
    public Sprite icon;
    public int id;
    public string namee;
    [TextArea(5,5)]
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
    public float menzili;
    public float hasari;
    public float hasarAlani;
    public float cd;
    public float manaBedeli;
}
