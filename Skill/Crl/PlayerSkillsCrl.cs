using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillsCrl : BaseSkillsCrl
{
    protected override void LoadSkill()
    {
        this.LoadSkill1();
    }
    protected virtual void LoadSkill1()
    {
       this.skillFirst = GetComponentInChildren<BuffShieldSkill>();
    }
}
