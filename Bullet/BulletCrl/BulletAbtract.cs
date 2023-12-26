using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbtract : TungMonoBehaviour
{
    [Header("Bullet Abtract")]
    [SerializeField] protected BulletCrl bulletCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadBulletCrl();
    }
    protected virtual void LoadBulletCrl()
    {
        this.bulletCrl = transform.parent.GetComponent<BulletCrl>();
    }
}
