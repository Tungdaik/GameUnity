using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSkill : BaseSkill

{
    protected static HealSkill instance;
    public static HealSkill Instance => instance;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    [SerializeField] protected int healAmount = 5;
    protected override void Effect()
    {
        gameCrl.ShipCrl.ShootableObjectDamReceiver.Heal(healAmount);
    }

    protected override void Uneffect()
    {
        
    }
}
