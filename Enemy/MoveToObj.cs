using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObj : Moving

{
    [SerializeField] Transform Obj;
    [SerializeField] float limitDistance = 5f;
    [SerializeField] float currentDistance = Mathf.Infinity;
    [SerializeField] protected Quaternion currentRot;
    [SerializeField] protected float speedRot = 0.5f;
    protected override void FixedUpdate()
    {
        this.GetTargetPosition();
        this.LookAtTarget();
        base.FixedUpdate();
    }
    protected override void GetTargetPosition()
    {
        this.targetPosition = Obj.position;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        currentDistance = diff.magnitude;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Quaternion Rot = Quaternion.Euler(0f,0f,-rot_z);
        currentRot = Quaternion.Lerp(transform.parent.rotation, Rot, speedRot);
        transform.parent.rotation = currentRot;
    }
    protected override bool CanMove()
    {
       return currentDistance > limitDistance;
    }
    protected override void SetFrontPoint()
    {
        this.frontPoint = transform.Find("FrontPoint");
    }
}
