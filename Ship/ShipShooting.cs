using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : Shooting
{
    protected override bool IsShooting()
    {
        return InputManager.Instance.OnFiring == 1;
    }
    protected override void FixedUpdate()
    {
        this.ChangeKindOfBullet();
        base.FixedUpdate();
    }

    protected virtual void ChangeKindOfBullet()
    {
        if (InputManager.Instance.O_OnDown) this.kindOfBullet = KindOfBulletEnum.Ditmemay;
        if (InputManager.Instance.I_OnDown) this.kindOfBullet = KindOfBulletEnum.Aothatday;

    }
}
