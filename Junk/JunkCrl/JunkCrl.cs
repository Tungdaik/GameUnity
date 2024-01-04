using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCrl : TungMonoBehaviour
{
    [SerializeField] protected Transform shape;
    [SerializeField] protected JunkDespawn junkDespawn;
    [SerializeField] protected JunkSO junkSO;
    [SerializeField] protected JunkDamReceiver junkDamReceiver;
    
    public JunkDamReceiver JunkDamReceiver { get { return junkDamReceiver; } }
    public JunkSO JunkSO { get { return junkSO; } }
    public JunkDespawn JunkDespawn {  get { return junkDespawn; } }

    public Transform Shape { get { return shape; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadShape();
        this.LoadSO();
        this.LoadJunkDamReceiver();
    } 
    protected virtual void LoadShape()
    {
        this.shape = transform.Find("Shape");
        this.junkDespawn = transform.GetComponentInChildren<JunkDespawn>();
    }
    protected virtual void LoadSO()
    {
        string addr = "Junk/" +transform.name;
        this.junkSO = Resources.Load<JunkSO>(addr);
    }
    protected virtual void LoadJunkDamReceiver()
    {
        this.junkDamReceiver = transform.GetComponentInChildren<JunkDamReceiver>();
    }
    
}
