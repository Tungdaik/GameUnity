using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamSender : DamageSender
{
    [SerializeField] protected BulletCrl bulletCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadBulletCrl();
    }
    
    protected virtual void LoadBulletCrl()
    {
        this.bulletCrl = this.transform.parent.GetComponent<BulletCrl>();
    }
    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        //Get FX Import
       this.GetImportFX();
        // Pooling object
        this.bulletCrl.BulletDespawn.DespawnObject();
    }
    protected void GetImportFX()
    {
        Transform newTrans = FXSpawner.Instance.Spawn("Impact_2", this.transform.parent.position, this.transform.parent.rotation);
        newTrans.gameObject.SetActive(true);
        
    }
}
