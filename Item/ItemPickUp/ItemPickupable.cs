using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : TungMonoBehaviour
{
    [SerializeField] protected SphereCollider _sphereCollider;
    [SerializeField] protected ItemCrl itemCrl;
    public ItemCrl ItemCrl { get { return itemCrl; } }
    protected void OnMouseDown()
    {
        PlayerCrl.Instance.PlayerPickUp.ItemPickUp(this);
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadSphereCollider();
        this.LoadItemCrl();
    }
    protected virtual void LoadSphereCollider()
    {
        this._sphereCollider = GetComponent<SphereCollider>();
        this._sphereCollider.isTrigger = true;
        this._sphereCollider.radius = 0.2f;
    }
    protected virtual void LoadItemCrl()
    {
        this.itemCrl = transform.parent.GetComponent<ItemCrl>();
    }
    public virtual void Picked()
    {
        itemCrl.IronDespawn.DespawnObject();
    }
    
}
