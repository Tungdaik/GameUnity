using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ParentFly
{
    protected int minRot = -16;
    protected int maxRot = 16;
    protected override void SetValue()
    {
        base.SetValue();
        objectSpeed = 1;
    }
    protected virtual void OnEnable()
    {
        this.SetRotationJunk();
    }
    protected virtual void SetRotationJunk()
    {
        Transform dgHouse = GameCrl.Instance.MainCam;
        Vector3 newTarget = dgHouse.position;
        newTarget.x += Random.Range(minRot, maxRot);
        newTarget.y += Random.Range(minRot, maxRot);
        Vector3 diff = newTarget - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, -rot_z);
    }
}
