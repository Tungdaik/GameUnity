using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSkillW : BaseButton
{
    [SerializeField] protected UISkillCrl uiCrl;
    [SerializeField] protected BulletStormSkill skill;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadUI();
        this.LoadSkill();
    }
    protected void FixedUpdate()
    {
        this.Solve();
    }
    protected override void Action()
    {
        Debug.LogWarning("W Used");
    }
    protected virtual void LoadUI()
    {
        this.uiCrl = GetComponent<UISkillCrl>();
    }
    protected virtual void LoadSkill()
    {
        this.skill = Transform.FindObjectOfType<BulletStormSkill>();
    }
    protected virtual void Solve()
    {
        if (skill.IsReady == false) uiCrl.Icon.gameObject.SetActive(false);
        else uiCrl.Icon.gameObject.SetActive(true);

    }
}
