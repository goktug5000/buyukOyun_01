using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class itemCode : MonoBehaviour
{
    public float pickUpR = 1f;
    public itemMaterial myCode;
    private SphereCollider myCollider;
    public int myAmount;

    public void Awake()
    {
        myCollider = this.gameObject.GetComponent<SphereCollider>();
        myCollider.isTrigger = true;
        myCollider.radius = pickUpR;

    }

    private void OnTriggerEnter(Collider other)
    {
        var inventoryHolerr = other.gameObject.GetComponent<inventoryHolder>();
        Debug.Log("bişi girdi");
        if (inventoryHolerr == null)
        {
            return;
        }

        if(inventoryHolerr.InventorySystem.AddToInventory(myCode, myAmount))
        {
            Debug.Log("aldım");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("boş yer yok");
        }
    }
}
