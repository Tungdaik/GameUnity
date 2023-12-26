using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawner
{
    [SerializeField] protected float limitDistance = 70;
    [SerializeField] protected float currentDistance = 0;
    [SerializeField] protected Transform mainCam;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCamera();
    }
    protected override bool CanDespawn()
    {
        this.currentDistance = Vector3.Distance(transform.position, this.mainCam.position);
        return this.currentDistance > limitDistance;
    }
    protected virtual void LoadCamera()
    {
        if (mainCam != null) return;
        this.mainCam = Transform.FindObjectOfType<Camera>().transform;
    }
}
