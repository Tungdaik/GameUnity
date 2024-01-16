using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtMeshHP : BaseTextMesh
{
    protected override void SetText()
    {
        int currentHP = ShipCrlBeta.Instance.ShootableObjectDamReceiver.CurrentHp;
        int maxHP = ShipCrlBeta.Instance.ShootableObjectDamReceiver.MaxHp;
        string text = currentHP.ToString() + "/" + maxHP.ToString();
        textMesh.SetText(text);
    }
}
