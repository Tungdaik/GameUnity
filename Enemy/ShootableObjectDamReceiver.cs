using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class ShootableObjectDamReceiver : DamageReceiver
{
    [SerializeField] protected ShootableObjectCrl shootableObjectCrl;
    public ShootableObjectCrl ShootableObjectCrl { get { return shootableObjectCrl; } }
    protected override void LoadCompoments()
    {
        this.LoadCrl();
        base.LoadCompoments();
        
    }
    protected override void LoadHP()
    {
        this.maxHp = this.shootableObjectCrl.ShootableObject.junkHp;
        base.LoadHP();
    }
    protected void LoadCrl()
    {
        this.shootableObjectCrl = transform.parent.GetComponent<ShootableObjectCrl>();
    }
    protected void FixedUpdate()
    {
        if (!this.IsDead()) return;
        this.GetDespawnFX();
        this.DropItem();
    }
    protected void GetDespawnFX()
    {
        Transform newTrans = FXSpawner.Instance.Spawn("Smoke_2", this.transform.parent.position, this.transform.parent.rotation);
        newTrans.gameObject.SetActive(true);
        this.shootableObjectCrl.Despawn.DespawnObject();
        this.isDead = false;
        this.currentHp = this.maxHp;
    }
     protected void DropItem()
    {
        List<DropRate> dropRates = shootableObjectCrl.ShootableObject.dropRate;
        ItemSpawner.Instance.Drop(dropRates,transform.parent.position,transform.parent.rotation);
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        this.currentHp = maxHp; 
    }
}
