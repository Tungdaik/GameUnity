using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnCrl : TungMonoBehaviour
{
    [SerializeField] protected JunkRandomPoints randomPoint;
    [SerializeField] protected JunkSpawner junkSpawn;
    public JunkSpawner JunkSpawn { get { return junkSpawn; } }
    public JunkRandomPoints JunkRandom {  get { return randomPoint; } }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadObject();
    }
    protected virtual void LoadObject()
    {
        if (this.junkSpawn != null) return;
        if (this.randomPoint != null) return;
        this.junkSpawn = Transform.FindObjectOfType<JunkSpawner>();
        this.randomPoint = Transform.FindObjectOfType<JunkRandomPoints>();
    }
}
