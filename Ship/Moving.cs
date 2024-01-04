using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public abstract class Moving : MonoBehaviour

{
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float speed = 0.01f;
    protected virtual void FixedUpdate()
    {
        
        this.Move();
    }
    
   /* protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, - rot_z);
    }
   */
    protected virtual void Move()

    {
         
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, this.speed);
        newPos.z = 0f;
        transform.parent.position = newPos;
    }
    protected abstract void GetTargetPosition();
}
