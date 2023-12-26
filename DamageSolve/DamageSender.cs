using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class DamageSender : TungMonoBehaviour
{
    [SerializeField] protected int damage = 1;
   
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        
    }
    
    public virtual void Send(Transform other)
    {
        DamageReceiver mTrans = other.GetComponentInChildren<DamageReceiver>();
        if (mTrans == null) return;
        this.Send(mTrans);

    }
    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(damage);
       
    }
    protected virtual void DestroyObject()
    {
        Destroy(transform.parent.gameObject);
    }
}
