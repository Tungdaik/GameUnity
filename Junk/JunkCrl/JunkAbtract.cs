using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkAbtract : TungMonoBehaviour
{
    [SerializeField] protected JunkCrl junkCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadJunkCrl();
    }
    protected virtual void LoadJunkCrl()
    {
        this.junkCrl = transform.parent.GetComponent<JunkCrl>();
    }
}
