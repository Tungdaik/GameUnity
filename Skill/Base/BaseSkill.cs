using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill : TungMonoBehaviour

{
    [Header("Base Skill")]
    [SerializeField] protected float currentTime = 0;
    [SerializeField] protected float cooldownTime;
    [SerializeField] protected bool isReady = false;
    [SerializeField] protected bool isRunning = false;
    [SerializeField] protected float effectTime = 5f;
    [SerializeField] protected float effectCount = 0;
    [SerializeField] protected bool use;
    protected virtual void FixedUpdate()
    {
        this.currentTime += Time.fixedDeltaTime;
        if (isRunning) effectCount += Time.fixedDeltaTime;
        if (currentTime > cooldownTime) isReady = true;
        if (effectCount > effectTime) this.CatchSkill();
        if (use && isReady) this.ThrowSkill();

    }
    
    protected virtual void ThrowSkill()
    {
        this.isReady = false;
        this.currentTime = 0;
        this.StartEffect();
    }
    protected virtual void CatchSkill()
    {
        this.effectCount = 0;
        this.StopEffect();
    }
    protected virtual void StartEffect()
    {
        isRunning = true;
        Effect();
    }
    protected virtual void StopEffect()
    {
        isRunning = false;
    }
    protected abstract void Effect();
}
