using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDameAbtract : TungMonoBehaviour
{
    [Header("Bullet Abtract")]
    [SerializeField] protected JunkCrl objCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadBulletCrl();
    }
    protected virtual void LoadBulletCrl()
    {
        this.objCrl = transform.parent.GetComponent<JunkCrl>();
    }
}
