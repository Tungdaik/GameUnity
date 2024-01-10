using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Moving

{
    [Header("Move To Target")]
    
    [SerializeField] protected Quaternion currentRot;
    [SerializeField] protected float speedRot = 0.05f;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.SetFrontPoint();
    }
    protected override void FixedUpdate()
    {
        this.GetTargetPosition();
        this.LookAtTarget();
        base.FixedUpdate();
    }
    protected override void GetTargetPosition()
    {
        this.targetPosition = InputManager.Instance.TargetPosition;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Quaternion Rot = Quaternion.Euler(0f, 0f, -rot_z);
        this.currentRot = Quaternion.Lerp(transform.parent.rotation, Rot, this.speedRot);
        transform.parent.rotation = currentRot;
    }
    protected override void SetFrontPoint()
    {
        this.frontPoint = transform.Find("FrontPoint");
    }
    protected override bool CanMove()
    {
        return true;
    }
}
