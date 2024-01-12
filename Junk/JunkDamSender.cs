using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamSender : DamageSender
{
    [SerializeField] protected JunkCrl junkCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadBulletCrl();
    }
    
    protected virtual void LoadBulletCrl()
    {
        this.junkCrl = this.transform.parent.GetComponent<JunkCrl>();
    }
    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        //Get FX Import
       this.GetImportFX();
        // Pooling object
        this.junkCrl.Despawn.DespawnObject();
    }
    protected void GetImportFX()
    {
        Transform newTrans = FXSpawner.Instance.Spawn("Impact_2", this.transform.parent.position, this.transform.parent.rotation);
        newTrans.gameObject.SetActive(true);
        
    }
}
