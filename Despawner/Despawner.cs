using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawner : TungMonoBehaviour
{
    protected void FixedUpdate()
    {
        if (!this.CanDespawn() || this.transform.parent.gameObject.activeSelf == false) return;
        this.DespawnObject();
    }
    protected abstract bool CanDespawn(); 
    public virtual void DespawnObject()
    {
        //for override
    }
}
