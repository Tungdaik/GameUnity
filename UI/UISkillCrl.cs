using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISkillCrl : TungMonoBehaviour
{
    [SerializeField] protected Transform bG;
    [SerializeField] protected Transform iconBG;
    [SerializeField] protected Transform cooldown;
    [SerializeField] protected Transform icon;
    public Transform BG => bG;
    public Transform IconBG => iconBG;
    public Transform Cooldown => cooldown;
    public Transform Icon => icon;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.Load();
    }
    protected virtual void Load()
    {
        this.bG = this.transform.Find("BG");
        this.iconBG = this.transform.Find("IconBG");
        this.cooldown = this.transform.Find("Cooldown");
        this.icon = this.transform.Find("Icon");
    }
}
