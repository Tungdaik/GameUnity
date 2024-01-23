using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : DespawnByTime
{
    public override void DespawnObject()
    {
        
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
