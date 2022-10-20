using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

[System.Serializable]
public class inventorySystem
{
    [SerializeField] private List<inventorySlot> inventorySlots;

    public List<inventorySlot> InventorySlots => inventorySlots;
    public int InventorySize => InventorySlots.Count;

    public UnityAction<inventorySlot> OnInventorySlotChanged;

    public inventorySystem(int size)
    {
        inventorySlots = new List<inventorySlot>(size);
        for (int i = 0; i < size; i++)
        {
            inventorySlots.Add(new inventorySlot());
        }
    }
    public bool denek;
    public bool AddToInventory(itemMaterial itemToAdd, int amountToAdd)
    {
        int itemEkenecekMiktar = amountToAdd;
        if(!ContainsSameItem(itemToAdd, amountToAdd, out itemEkenecekMiktar))
        {
            Debug.Log("ortak eşya bulunamadı yenisi ekleniyor");
            //inventorySlots[0] = new inventorySlot(itemToAdd, itemEkenecekMiktar);
            int i = 0;
            foreach(var slot in inventorySlots)
            {
                if (inventorySlots[i].ItemData == null)
                {
                    //boş yere EKLEME
                    inventorySlots[i] = new inventorySlot(itemToAdd, itemEkenecekMiktar);
                    return true;
                }
                i++;
            }

            return false;
        }
        
        
        
        return true;
    }

    public bool ContainsSameItem(itemMaterial itemToAdd, int amountToAdd, out int artan)
    {
        artan = amountToAdd;
        foreach (var slot in inventorySlots)
        {
            
            if(slot.ItemData == itemToAdd)
            {
                //Debug.Log("eklemeden önce eklenecek parça: " + amountToAdd);
                slot.RoomLeftInStack(amountToAdd, out int kacYerVar);
                if (kacYerVar >= amountToAdd)
                {
                    slot.AddToStack(amountToAdd);
                    Debug.Log(amountToAdd + " hepsi eklendi");

                    return true;
                }
                else
                {
                    slot.AddToStack(kacYerVar);
                    
                    artan = amountToAdd - kacYerVar;
                    Debug.Log(kacYerVar + " eklendi, " + artan + " arttı");
                }
                

                //Debug.Log("eklemeden sonra eklenecek parça: " + amountToAdd);
                //Debug.Log("eklemeden sonra kalan yer: " + bosOlanYer);
                //Debug.Log(slot.ItemData);
                
            }
        }
        
        return false;

        
    }

}
