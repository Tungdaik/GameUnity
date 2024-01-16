using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : TungMonoBehaviour
{
    [SerializeField] protected Button button;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadButton();
    }
    protected override void Awake()
    {
        base.Awake();
        this.LoadFunc();
    }
    protected virtual void LoadFunc()
    {
        this.button.onClick.AddListener(Action);
    }
    protected virtual void LoadButton()
    {
        this.button = GetComponent<Button>();
    }
    protected abstract void Action();

}
