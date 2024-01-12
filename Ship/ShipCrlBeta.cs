using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCrlBeta : ShootableObjectCrl
{
    [SerializeField] protected Inventory inventory;
    public Inventory Inventory { get { return inventory; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadInventory();
    }
    protected override string GetName()
    {
        return ObjectTypeEnum.Ship.ToString();
    }
    protected virtual void LoadInventory()
    {
        this.inventory = transform.GetComponentInChildren<Inventory>();
    }
}
