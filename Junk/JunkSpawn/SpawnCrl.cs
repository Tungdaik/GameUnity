using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrl : TungMonoBehaviour
{
    [SerializeField] protected JunkRandomPoints randomPoint;
    [SerializeField] protected Spawner spawner;
    public Spawner JunkSpawn { get { return spawner; } }
    public JunkRandomPoints JunkRandom {  get { return randomPoint; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadObject();
    }
    protected virtual void LoadObject()
    {
        if (this.spawner != null) return;
        if (this.randomPoint != null) return;
        this.spawner = transform.GetComponent<Spawner>();
        this.randomPoint = Transform.FindObjectOfType<JunkRandomPoints>();
    }
}
