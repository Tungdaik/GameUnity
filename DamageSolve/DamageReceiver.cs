using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : TungMonoBehaviour
{
    [SerializeField] protected int currentHp;
    [SerializeField] protected int maxHp = 5;
    
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadHP();
       

    }
    
    
    protected virtual void LoadHP()
    {
        this.currentHp = this.maxHp;
    }
    public virtual void Deduct(int damage)
    {
        currentHp -= damage;
        if(currentHp < 0) { currentHp = 0; }
    }
    protected virtual bool IsDead()
    {
        return currentHp <= 0;
    }
}
