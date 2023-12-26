using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawner : TungMonoBehaviour
{
    protected void FixedUpdate()
    {
        if (!this.CanDespawn()) return;
        this.DespawnObject();
    }
    protected abstract bool CanDespawn(); 
    public virtual void DespawnObject()
    {
        //for override
    }
}
