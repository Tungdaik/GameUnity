using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCrl : TungMonoBehaviour
{
    [SerializeField] protected Transform shape;
    public Transform Shape { get { return shape; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadShape();
    } 
    protected virtual void LoadShape()
    {
        this.shape = transform.Find("Shape");
    }
}
