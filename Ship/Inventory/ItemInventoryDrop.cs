using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventoryDrop : InventoryAbtract
{
    protected override void Start()
    {
        base.Start();
        //this.DropItem(0);
    }
    protected virtual void DropItem(int index)
    {
        if (index > inventory.Items.Count) return;
        ItemInventory item = inventory.Items[index];
        ItemCodeEnum itemCode = item.itemProfile.itemCode;
        int currentLevel = item.currentLevel;
        Vector3 pos = transform.parent.position;
        pos.x -= 1;
        ItemSpawner.Instance.Drop(itemCode, currentLevel,pos, transform.parent.rotation);
    } 
}
