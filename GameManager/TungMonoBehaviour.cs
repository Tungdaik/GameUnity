using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TungMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadCompoments();
        this.SetValue();
    }
    protected virtual void Awake()
    {
        this.LoadCompoments();
    }
    protected virtual void Start()
    {
        //for override
    }
    protected virtual void LoadCompoments()
    {
        //for overide
    }
    protected virtual void SetValue()
    {
        //for override
    }
    protected virtual void OnEnable()
    {
        //for override
    }
}
