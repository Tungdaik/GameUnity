using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipDespawn : Despawner
{
    public override void DespawnObject()
    {
        ShipSpawner.Instance.Despawn(transform.parent);

    }
    protected override bool CanDespawn()
    {
        return false;
    }
}
