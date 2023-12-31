using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipCrl : TungMonoBehaviour
{
    [SerializeField] protected Inventory inventory;
    public Inventory Inventory { get { return inventory; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadInventory();
    }
    protected virtual void LoadInventory()
    {
        this.inventory = transform.GetComponentInChildren<Inventory>();
    }
}
