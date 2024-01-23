using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : TungMonoBehaviour
{
    [SerializeField] protected BulletCrl bulletCrl;
    [SerializeField] protected Transform targetObj;
    [SerializeField] protected float speedRot = 1.0f;
    [SerializeField] Quaternion currentRot;
    protected void FixedUpdate()
    {
        this.FollowObj();
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected virtual void LoadCrl()
    {
        this.bulletCrl = transform.parent.GetComponent<BulletCrl>();
    }
    protected virtual void FollowObj()
    {
        Vector3 diff = this.targetObj.position - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Quaternion Rot = Quaternion.Euler(0f, 0f, -rot_z);
        currentRot = Quaternion.Lerp(transform.parent.rotation, Rot, speedRot);
        transform.parent.rotation = currentRot;
    }
}
