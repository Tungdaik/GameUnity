using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeGunsSkill : BaseSkill
{
    [SerializeField] protected BaseCrl objCrl;
    [SerializeField] protected float effectTime = 5f;
    [SerializeField] protected float effectCount = 0;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    
    protected virtual void LoadCrl()
    {
        this.objCrl = transform.parent.GetComponent<BaseCrl>();
    }
    protected override void ThrowSkill()
    {
        throw new System.NotImplementedException();
    }
    protected virtual void Throw()
    {

    }
    protected virtual void Stop()
    {

    }
}
