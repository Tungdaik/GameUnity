using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtMeshCD_W : BaseTextMesh
{
    [SerializeField] protected BulletStormSkill skill;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadSkill();
    }
    protected override void SetText()
    {
        int c = (int)skill.CooldownRemainTime;
        this.textMesh.SetText(c.ToString());
    }
    protected virtual void LoadSkill()
    {
        this.skill = Transform.FindObjectOfType<BulletStormSkill>();
    }
}
