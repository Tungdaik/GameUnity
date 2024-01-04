using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAbtract : TungMonoBehaviour
{
    [Header("Iventory Abtract")]
    [SerializeField] protected Inventory inventory;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadInventory();
    }
    protected virtual void LoadInventory()
    {
        this.inventory = transform.parent.GetComponent<Inventory>();
    }
}
