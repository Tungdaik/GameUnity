using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(SphereCollider))]
public class DamageImport : BulletAbtract
{
    [Header("Damage Import")]
    [SerializeField] protected SphereCollider spheCollider;
    [SerializeField] protected Rigidbody _rigidBody;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadData();
    }
    protected virtual void LoadData()
    {
        this.spheCollider = GetComponent<SphereCollider>();
        this._rigidBody = GetComponent<Rigidbody>();

        this.spheCollider.isTrigger = true;
        this.spheCollider.radius = 0.2f;
        this._rigidBody.isKinematic = true;
    }
   protected virtual void OnTriggerEnter(Collider other)
    {
        if (ThatIsYou(other)) return;
        this.bulletCrl.BulletDamSender.Send(other.transform);
    }
    protected virtual bool ThatIsYou(Collider other)
    {
       return  other.transform.parent.name == this.bulletCrl.ShooterName;
    }
}
