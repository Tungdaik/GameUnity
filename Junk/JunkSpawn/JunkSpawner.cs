using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    [SerializeField] protected static JunkSpawner instance;
    public static JunkSpawner Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        JunkSpawner.instance = this;
    }
}
