using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveToTargetObj : BaseMoving
{
    [Header("Move To Target Object")]
    [SerializeField] protected Transform targetTransform;
    protected override void FixedUpdate()
    {

        this.GetTargetTransform();
        this.Rotation();
        base.FixedUpdate();
    }



    protected override void Rotation()
    {
        Vector3 diff = this.targetTransform.position - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Quaternion Rot = Quaternion.Euler(0f, 0f, -rot_z);
        this.currentRot = Quaternion.Lerp(transform.parent.rotation, Rot, this.speedRotation);
        transform.parent.rotation = currentRot;
    }
    protected abstract void GetTargetTransform();
}
