using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class ShipMoving : MonoBehaviour

{
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float speed = 0.01f;
    void FixedUpdate()
    {
        this.SetWorldPosition();
        this.LookAtTarget();
        this.Moving();
    }
     protected virtual void SetWorldPosition()
    {
        this.targetPosition = InputManager.Instance.TargetPosition;
        this.targetPosition.z = 0f;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, - rot_z);
    }
    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, this.speed);
        newPos.z = 0f;
        transform.parent.position = newPos;
    }
}
