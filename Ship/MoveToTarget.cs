using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Moving

{
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
        transform.parent.rotation = Quaternion.Euler(0f, 0f, -rot_z);
    }
}
