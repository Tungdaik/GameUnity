using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffShieldSkill : BaseSkill
{
    protected static BuffShieldSkill instance;
    public static BuffShieldSkill Instance => instance;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    protected override void Effect()
    {
       this.gameCrl.ShipCrl.Shield.gameObject.SetActive(true);
    }

    protected override void Uneffect()
    {
        this.gameCrl.ShipCrl.Shield.gameObject.SetActive(false);
    }
}
