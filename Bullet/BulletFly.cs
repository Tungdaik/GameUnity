using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BulletFly : ParentFly
{
    protected override void SetValue()
    {
        base.SetValue();
        objectSpeed = 10;
    }
}
