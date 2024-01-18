using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill : TungMonoBehaviour

{
    [Header("Crl")]
    [SerializeField] protected GameCrl gameCrl;
    public GameCrl GameCrl => gameCrl;
    [Header("Base Skill")]
    [SerializeField] protected float currentTime = 0;
    [SerializeField] protected float cooldownRemainTime;
    public float CooldownRemainTime => cooldownRemainTime;
    [SerializeField] protected float cooldownTime;
    [SerializeField] protected bool isReady = false;
    public bool IsReady => isReady;
    [SerializeField] protected bool isRunning = false;
    public float CurrentTime => currentTime;
    [SerializeField] protected float effectTime = 5f;
    [SerializeField] protected float effectCount = 0;
   
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected virtual void FixedUpdate()
    {
        this.currentTime += Time.fixedDeltaTime;
        this.cooldownRemainTime = Mathf.Max(0,cooldownTime- currentTime);
        if (isRunning)
        {
            effectCount += Time.fixedDeltaTime;
            currentTime = 0;
        }
        if (currentTime > cooldownTime) isReady = true;
        if (effectCount > effectTime) this.CatchSkill();
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
        Uneffect();
    }
    public virtual void Use()
    {
        if (!isReady) return;
        this.ThrowSkill();
    }
    protected virtual void LoadCrl()
    {
        this.gameCrl = Transform.FindObjectOfType<GameCrl>();   
    }
    protected abstract void Effect();
    protected abstract void Uneffect();
}
