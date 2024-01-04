using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : TungMonoBehaviour
{
    [SerializeField] protected PlayerCrl playerCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadPlayerCrl();
    }
    protected virtual void LoadPlayerCrl()
    {
        this.playerCrl = transform.parent.GetComponent<PlayerCrl>();
    }
    public virtual void ItemPickUp(ItemPickupable itemPickupable)
    {
        if (playerCrl.CurrentShip.Inventory.Add(itemPickupable.ItemCrl.ItemProfileSO.itemCode, 1,itemPickupable.ItemCrl.CurrentLevel))
        {
            itemPickupable.Picked();
        }
    }
}
