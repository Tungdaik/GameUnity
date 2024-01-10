using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingDet : MoveToObj
{
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.SetFrontPoint();
    }
}
