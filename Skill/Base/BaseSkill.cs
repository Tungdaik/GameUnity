using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill : TungMonoBehaviour

{
    [Header("Base Skill")]
    [SerializeField] protected float currentTime;
    [SerializeField] protected float cooldownTime;
    [SerializeField] protected bool isReady = false;
    [SerializeField] protected bool isRunning = false;
    protected virtual void FixedUpdate()
    {
        this.currentTime += Time.fixedDeltaTime;
        if (this.currentTime < cooldownTime) return;
        this.isReady = true;
        if (!this.isRunning) return;
        this.Use();

    }
    protected virtual void Use()
    {
        if (!isReady) return;
        this.ThrowSkill();
        isReady = false;
        isRunning = false;
        currentTime = 0;
    }
    protected abstract void ThrowSkill();
}
