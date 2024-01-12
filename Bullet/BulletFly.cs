using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BulletFly : ParentFly
{
    [SerializeField] protected BulletCrl bulletCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected override void SetValue()
    {
        base.SetValue();
        this.objectSpeed = bulletCrl.BulletProfileSO.speed;
    }
    protected virtual void LoadCrl()
    {
        this.bulletCrl = transform.parent.GetComponent<BulletCrl>();
    }
}
