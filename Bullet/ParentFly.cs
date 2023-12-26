using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFly : TungMonoBehaviour
{
    [SerializeField] protected float objectSpeed = 10f;
    [SerializeField] protected Vector3 direction = Vector3.up;
    private void FixedUpdate()
    {
        transform.parent.Translate(direction * objectSpeed * Time.deltaTime);
    }
}
