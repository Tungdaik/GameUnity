using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : TungMonoBehaviour
{
    [SerializeField] protected Transform targetObj;
    [SerializeField] protected float speed = 5f;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadTargetObj();
    }
    protected virtual void LoadTargetObj()
    {
        this.targetObj = Transform.FindObjectOfType<ShipCrl>().transform;
    }
    protected void FixedUpdate()
    {
        this.FollowObj();
    }
    protected virtual void FollowObj()
    {
        transform.position = Vector3.Lerp(this.transform.position, this.targetObj.position,Time.fixedDeltaTime * speed );
    }
}
