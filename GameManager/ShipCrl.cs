using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipCrl : TungMonoBehaviour
{
    [SerializeField] protected Inventory inventory;
    [SerializeField] protected SpaceShipSO spaceShipSO;
    public SpaceShipSO SpaceShipSO => spaceShipSO;
    public Inventory Inventory { get { return inventory; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadInventory();
        this.LoadSpaceShipSO();
    }
    protected virtual void LoadInventory()
    {
        this.inventory = transform.GetComponentInChildren<Inventory>();
    }
    protected virtual void LoadSpaceShipSO()
    {
        string addr = "ShootableObject/SpaceShip/" + transform.name;
        this.spaceShipSO = Resources.Load<SpaceShipSO>(addr);
    }
}
