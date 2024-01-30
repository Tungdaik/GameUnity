using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent (typeof(SphereCollider))]
public class JunkDamageImport : JunkDameAbtract
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
        this.objCrl.DamageSender.Send(other.transform);
    }
    protected virtual bool ThatIsYou(Collider other)
    {
       bool if1 = other.transform.parent.name == this.transform.parent.name;
        bool if2 = other.transform.parent.parent.parent.name == "EnemySpawner";
       return  if1||if2;
    }
}
