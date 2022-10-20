using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class inventoryHolder : MonoBehaviour
{
    [SerializeField] private int inventorySize;
    [SerializeField] protected inventorySystem inventorySystemm;

    public static UnityAction<inventorySystem> OnInventorySystemChanged;

    public inventorySystem InventorySystem => inventorySystemm;

    private void Awake()
    {
        inventorySystemm = new inventorySystem(inventorySize);
    }
}
