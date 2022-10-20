using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prefabs / Items")]
public class itemMaterial : ScriptableObject
{
    public Sprite icon;
    public int id;
    public string namee;
    [TextArea(5, 5)]
    public string aciklama;
    public float costBuy;
    public float costSell;
    public int maxStackSize;
}
