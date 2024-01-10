using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : Spawner
{
    [SerializeField] protected static ShipSpawner instance;
    public static ShipSpawner Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        ShipSpawner.instance = this;
    }
}
