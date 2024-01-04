using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronDespawn : DespawnByTime
{ 
    protected override void SetValue()
    {
        base.SetValue();
        this.limitTime = 5f;
    }
    public override void DespawnObject()
    {

        ItemSpawner.Instance.Despawn(transform.parent);
    }
}
