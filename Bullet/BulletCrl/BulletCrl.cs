using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrl : TungMonoBehaviour
{
    [SerializeField] protected BulletDamSender bulletDamSender;
    [SerializeField] protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get { return bulletDespawn; } }
    public BulletDamSender BulletDamSender { get { return bulletDamSender; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadDamageSender();
    }
    protected virtual void LoadDamageSender()
    {
        this.bulletDamSender = transform.GetComponentInChildren<BulletDamSender>();
        this.bulletDespawn =transform.GetComponentInChildren<BulletDespawn>();
    }
}
