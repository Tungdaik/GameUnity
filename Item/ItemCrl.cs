using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCrl : TungMonoBehaviour
{
    [SerializeField] protected ItemProfileSO itemProfileSO;
    [SerializeField] protected IronDespawn ironDespawn;
    [SerializeField] protected int currentLevel = 0;
    public int CurrentLevel { get {  return currentLevel; } }
   
    public IronDespawn IronDespawn { get { return ironDespawn; } }
    public ItemProfileSO ItemProfileSO { get { return itemProfileSO; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadItemProfileSO();
        this.LoadIronDespawn();
    }
    protected virtual void LoadItemProfileSO()
    {
        string addr = "ItemProfiles/" + transform.name;
        this.itemProfileSO = Resources.Load<ItemProfileSO>(addr);
    }
    protected virtual void LoadIronDespawn()
    {
        this.ironDespawn = transform.GetComponentInChildren<IronDespawn>();
    }
    public virtual void SetLevel(int level)
    {
        this.currentLevel = level;
    }
}
