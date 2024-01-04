using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawner
{
    [SerializeField] protected float limitTime = 2f;
    [SerializeField] protected float currentTime = 0;
    protected override void OnEnable()
    {
        base.OnEnable();
        currentTime = 0f;
    }
    protected override bool CanDespawn()
    {
        currentTime += Time.fixedDeltaTime;
        return currentTime > limitTime;
    }
}
