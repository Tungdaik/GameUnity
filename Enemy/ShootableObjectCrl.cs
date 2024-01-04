using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootableObjectCrl : TungMonoBehaviour
{
    [SerializeField] protected Transform shape;
    [SerializeField] protected Despawner despawner;
    [SerializeField] protected ShootableObject shootableObject;
    [SerializeField] protected ShootableObjectDamReceiver shootableObjectDamReceiver;

    public ShootableObjectDamReceiver ShootableObjectDamReceiver { get { return shootableObjectDamReceiver; } }
    public ShootableObject ShootableObject { get { return shootableObject; } }
    public Despawner Despawn { get { return despawner; } }

    public Transform Shape { get { return shape; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadShape();
        this.LoadSO();
        this.LoadDamReceiver();
    }
    protected virtual void LoadShape()
    {
        this.shape = transform.Find("Shape");
        this.despawner = transform.GetComponentInChildren<Despawner>();
    }
    protected virtual void LoadSO()
    {
        string addr = "ShootableObject/" + this.GetName() +"/" + transform.name;
        this.shootableObject = Resources.Load<ShootableObject>(addr);
    }
    protected virtual void LoadDamReceiver()
    {
        this.shootableObjectDamReceiver = transform.GetComponentInChildren<ShootableObjectDamReceiver>();
    }
    protected abstract string GetName();
}
