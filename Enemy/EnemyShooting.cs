using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : Shooting
{
    [SerializeField] protected Transform targetObj;
    [SerializeField] protected float limitDistance = 5f;
    protected override bool IsShooting()
    {
        return Vector3.Distance(targetObj.position, transform.parent.position) <= this.limitDistance;
    }
}
