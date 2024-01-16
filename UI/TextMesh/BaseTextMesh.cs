using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;



public abstract class BaseTextMesh : TungMonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI textMesh;
    protected void FixedUpdate()
    {
        this.SetText();
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadTextMesh();
    }
    protected virtual void LoadTextMesh()
    {
        this.textMesh = GetComponent<TextMeshProUGUI>();
    }
    protected abstract void SetText();
}
