using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class JunkDamReceiver : DamageReceiver
{
    [SerializeField] protected JunkCrl junkCrl;
    public JunkCrl BulletCrl { get { return junkCrl; } }
    protected override void LoadCompoments()
    {
        this.LoadCrl();
        base.LoadCompoments();
        
    }
    protected override void LoadHP()
    {
        this.maxHp = this.junkCrl.JunkSO.junkHp;
        base.LoadHP();
    }
    protected void LoadCrl()
    {
        this.junkCrl = transform.parent.GetComponent<JunkCrl>();
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
        this.junkCrl.JunkDespawn.DespawnObject();
        this.isDead = false;
        this.currentHp = this.maxHp;
    }
     protected void DropItem()
    {
        List<DropRate> dropRates = junkCrl.JunkSO.dropRate;
        ItemSpawner.Instance.Drop(dropRates,transform.parent.position,transform.parent.rotation);
    }
}
