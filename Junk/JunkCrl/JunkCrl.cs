using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class JunkCrl : ShootableObjectCrl
{
    [Header("Junk Crl")]
    [SerializeField] protected JunkDamSender junkDameSender;
    public JunkDamSender DamageSender => junkDameSender;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadDamSender();
    }
    protected override string GetName()
    {
        return ObjectTypeEnum.Junk.ToString();
    }
    protected virtual void LoadDamSender()
    {
        this.junkDameSender = this.GetComponentInChildren<JunkDamSender>();
    }
}
