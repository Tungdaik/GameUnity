using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    [SerializeField] protected static FXSpawner instance;
    public static FXSpawner Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        FXSpawner.instance = this;
    }
}
