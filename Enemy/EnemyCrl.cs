using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrl : ShootableObjectCrl
{
    protected override string GetName()
    {
        return ObjectTypeEnum.Enemy.ToString();
    }
}
