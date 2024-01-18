using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract  class BaseSlider : TungMonoBehaviour
{
    [SerializeField] protected Slider slider;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadSlider();
    }
    protected override void Awake()
    {
        base.Awake();
        this.LoadFunc();
    }
    protected virtual void LoadFunc()
    {
        this.slider.onValueChanged.AddListener(this.OnChanged);
    }
    protected virtual void OnChanged(float a)
    {
       //
    }
    protected virtual void LoadSlider()
    {
        this.slider = GetComponent<Slider>();
    }
    protected abstract void SetVal();

}
