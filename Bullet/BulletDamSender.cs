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
        // Pooling object
        this.bulletCrl.BulletDespawn.DespawnObject();
    }

}
