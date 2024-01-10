using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrl : BaseCrl
{
    [SerializeField] protected BulletDamSender bulletDamSender;
    [SerializeField] protected BulletDespawn bulletDespawn;
    [SerializeField] protected string shooterName;
    public string ShooterName { get { return shooterName; } }
    public BulletDespawn BulletDespawn { get { return bulletDespawn; } }
    public BulletDamSender BulletDamSender { get { return bulletDamSender; } }
    public void SetShooterName(string shooterName)
    {
        this.shooterName = shooterName;
    }
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
