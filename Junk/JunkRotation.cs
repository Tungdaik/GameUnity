using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotation : JunkAbtract
{
    [SerializeField] protected float speed = 9f;
    protected void FixedUpdate()
    {
        this.Rotation();
    }
    protected void Rotation()
    {
        Vector3 dirc = new Vector3(0,0,1);
        this.junkCrl.Shape.Rotate(dirc*this.speed*Time.fixedDeltaTime);
    }

    
}
