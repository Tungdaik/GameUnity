using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class JunkCrl : ShootableObjectCrl
{
    protected override string GetName()
    {
        return ObjectTypeEnum.Junk.ToString();
    }
}
