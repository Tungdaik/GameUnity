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
       
        base.FixedUpdate();
    }

    
}
