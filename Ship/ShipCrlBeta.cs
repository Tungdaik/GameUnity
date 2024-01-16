using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCrlBeta : ShootableObjectCrl

{
    [SerializeField] protected Shield shield;
    public Shield Shield => shield;
    [SerializeField] protected PlayerSkillsCrl playerSkillsCrl;
    public PlayerSkillsCrl PlayerSkillsCrl => playerSkillsCrl;

    [SerializeField] protected Inventory inventory;
    public Inventory Inventory { get { return inventory; } }
    [SerializeField] protected static ShipCrlBeta instance;
    public static ShipCrlBeta Instance => instance;
    protected override void Awake()
    {
        base.Awake();
        ShipCrlBeta.instance = this;
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadInventory();
        this.LoadSkillCrl();
        this.LoadShield();
    }
    protected virtual void LoadSkillCrl()
    {
        this.playerSkillsCrl = GetComponentInChildren<PlayerSkillsCrl>(); 
    }
    protected override string GetName()
    {
        return ObjectTypeEnum.Ship.ToString();
    }
    protected virtual void LoadInventory()
    {
        this.inventory = transform.GetComponentInChildren<Inventory>();
    }
    protected virtual void LoadShield()
    {
        this.shield = GetComponentInChildren<Shield>(); 
        this.shield.gameObject.SetActive(false);
    }
}
