using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnExit : BaseButton
{
    protected override void Action()
    {
        BuffShieldSkill.Instance.Use();
    }
}
