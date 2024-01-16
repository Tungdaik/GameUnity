using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class BaseSkillsCrl : TungMonoBehaviour
{
    [SerializeField] protected BuffShieldSkill skillFirst;
   
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadSkill();
    }
    protected abstract void LoadSkill();


}
