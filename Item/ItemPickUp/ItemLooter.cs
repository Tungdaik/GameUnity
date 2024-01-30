using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(SphereCollider))]
public class ItemLooter : InventoryAbtract
{
    [Header("Item Looter")]
    [SerializeField] protected Rigidbody _rigidbody;
    [SerializeField] protected SphereCollider _sphereCollider;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadRigidbody();
        this.LoadSphereCollider();
       // this.LoadInventory();
    }
    protected virtual void LoadRigidbody()
    {
        this._rigidbody = GetComponent<Rigidbody>();
        this._rigidbody.isKinematic = true;
    }
    protected virtual void LoadSphereCollider()
    {
        this._sphereCollider = GetComponent<SphereCollider>();
        this._sphereCollider.isTrigger = true;
        this._sphereCollider.radius = 0.3f;
    }
   // protected virtual void LoadInventory()
    //{
      //  this.inventory = transform.parent.GetComponent<Inventory>();
    //}
    protected virtual void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.GetComponent<ItemPickupable>() == null) return;

        ItemPickupable itemPickupable = collider.transform.GetComponent<ItemPickupable>();
        if (itemPickupable.ItemCrl.ItemProfileSO.itemType == ItemTypeEnum.Resource) this.LootRes(itemPickupable);
        if (itemPickupable.ItemCrl.ItemProfileSO.itemType == ItemTypeEnum.Equipment) this.LootEquip(itemPickupable);
    }
    protected void LootRes(ItemPickupable itemPickupable)
    {
        
        int currentLevel = itemPickupable.ItemCrl.CurrentLevel;
        if (this.inventory.Add(itemPickupable.ItemCrl.ItemProfileSO.itemCode, 1, currentLevel))
        {
            itemPickupable.Picked();
        }
    }
    protected void LootEquip(ItemPickupable itemPickupable)
    {
        int currentLevel = itemPickupable.ItemCrl.CurrentLevel;
        if (this.inventory.Add(itemPickupable.ItemCrl.ItemProfileSO.itemCode, 1, currentLevel))
        {
            itemPickupable.Picked();
        }
    }
}
