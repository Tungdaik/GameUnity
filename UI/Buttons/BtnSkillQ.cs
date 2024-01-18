using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BtnSkillQ : BaseButton
{
    [SerializeField] protected UISkillCrl uiCrl;
    [SerializeField] protected BuffShieldSkill skill;
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
        Debug.LogWarning("Q Used");
    }
    protected virtual void LoadUI()
    {
        this.uiCrl = GetComponent<UISkillCrl>();
    }
    protected virtual void LoadSkill()
    {
        this.skill = Transform.FindObjectOfType<BuffShieldSkill>();
    }
    protected virtual void Solve()
    {
        if(skill.IsReady == false) uiCrl.Icon.gameObject.SetActive(false);
        else uiCrl.Icon.gameObject.SetActive(true);
        
    }
}
