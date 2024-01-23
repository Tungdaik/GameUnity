using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoving : MoveToTargetPoint
{
    [Header("Ship Moving")]
    [SerializeField] protected ShipCrlBeta  shipCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadShipCrl();
    }
    protected override void SetValue()
    {
        base.SetValue();
        
        this.moveType = MoveTypeEnum.Move;
    }
    protected override void GetTargetPoint()
    {
      //  if (InputManager.Instance.OnMoving == 1) 
         //   this.moveType = MoveTypeEnum.Move;
       // else this.moveType = MoveTypeEnum.Default;
        this.targetPoint = InputManager.Instance.TargetPosition;
    }
    protected virtual void LoadShipCrl()
    {
        this.shipCrl = transform.parent.GetComponent<ShipCrlBeta>();
    }
}
