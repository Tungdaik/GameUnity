using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : TungMonoBehaviour
{
    [Header("Base")]
    [SerializeField] protected int currentHp;
    [SerializeField] protected int maxHp = 5;
    [SerializeField] protected bool isDead = false;
    public int CurrentHp => currentHp;
    public int MaxHp => maxHp;
 
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadHP();
       

    }
    public virtual void Heal(int a)
    {
        if (isDead) return;
        currentHp += a;
        if(currentHp > maxHp) currentHp = maxHp;
    }
    
    protected virtual void LoadHP()

    {

        this.currentHp = this.maxHp;
    }
    public virtual void Deduct(int damage)
    {   
        if(isDead) return;
        currentHp -= damage;
        if(currentHp <= 0) { 
            currentHp = 0;
            isDead = true;
        }
    }
    protected virtual bool IsDead()
    {
        return isDead;
    }
}
