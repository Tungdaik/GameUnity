using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    [SerializeField] protected static BulletSpawner instance;
    public static BulletSpawner Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        BulletSpawner.instance = this;
    }
}
