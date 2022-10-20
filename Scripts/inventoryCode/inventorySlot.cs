using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class inventorySlot
{
    [SerializeField] private itemMaterial itemData;
    [SerializeField] private int stackSize;


    public itemMaterial ItemData => itemData;
    public int StackSize => stackSize;


    public inventorySlot(itemMaterial myMaterial, int amount)
    {
        itemData = myMaterial;
        stackSize = amount;
    }

    public inventorySlot()
    {
        ClearSlot();
    }

    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }
    public bool RoomLeftInStack(int amount, out int amountLeft)
    {
        amountLeft = itemData.maxStackSize - stackSize;
        return RoomLeftInStack(amount);
    }
    public bool RoomLeftInStack(int amount)//x tane yer var mı
    {
        if(amount + stackSize <= itemData.maxStackSize)
        {//sığdı
            return true;//2 mal aldım 2 de vardı ama 10 tane stack oluyo
        }
        else
        {//sığmadı
            return false;//5 mal aldım 5 de vardı ama 2 tane stack oluyo
        }
    }

    public void AddToStack(int amount)
    {
        stackSize += amount;
    }
    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }
}
