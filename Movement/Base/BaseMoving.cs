using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMoving : TungMonoBehaviour
{
    [Header("Base Moving")]
    [SerializeField] protected float speedMove;
    [SerializeField] protected float speedRotation;
    [SerializeField] protected Transform frontPoint;
    [SerializeField] protected Quaternion currentRot;
    [SerializeField] protected MoveTypeEnum moveType;
    protected virtual void FixedUpdate()
    {
        this.Moving();
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadFrontPoint();
    }
    protected void LoadFrontPoint()
    {
        this.frontPoint = transform.Find("FrontPoint");
    }
    protected  void Moving()
    {
        if (moveType == MoveTypeEnum.Default) return;
        this.Move();
    }
    protected abstract void Rotation();
    protected void Move()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, frontPoint.position, speedMove);
        this.transform.parent.position = newPos;
    }
}
