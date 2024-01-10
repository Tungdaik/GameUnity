using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MoveToTargetObj

{
    [Header("Enemy Moving")]
    [SerializeField] protected ShootableObjectCrl objCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadObjCrl();
    }
    protected override void GetTargetTransform()
    {
       float distance = Vector3.Distance(targetTransform.position,transform.parent.position);
       if(distance >=7) this.moveType = MoveTypeEnum.Move;
       else this.moveType = MoveTypeEnum.Default;
    }
    protected virtual void LoadObjCrl()
    {
        this.objCrl = transform.parent.GetComponent<ShootableObjectCrl>();  
    }
}
