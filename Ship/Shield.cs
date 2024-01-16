using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : DamageReceiver
{
    protected void FixedUpdate()
    {
        if (!isDead) return;
        isDead = true;
        transform.gameObject.SetActive(false);
        this.currentHp = maxHp;
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        this.isDead = false;
    }
}
