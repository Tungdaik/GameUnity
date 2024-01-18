using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderHP : BaseSlider
{
    [SerializeField] protected ShipCrlBeta shipCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected void FixedUpdate()
    {

        this.SetVal();
    }
    protected override void SetVal()
    {
        this.slider.value = (float)this.shipCrl.ShootableObjectDamReceiver.CurrentHp / this.shipCrl.ShootableObjectDamReceiver.MaxHp;
    }
    protected virtual void LoadCrl()
    {
        this.shipCrl = Transform.FindObjectOfType<ShipCrlBeta>();   
    }
}
