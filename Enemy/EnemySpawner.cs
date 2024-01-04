using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    [SerializeField] protected static EnemySpawner instance;
    public static EnemySpawner Instance { get { return instance; } }
   /*protected override void Start()
    {
        base.Start();
        Vector3 vector3 = Vector3.zero;
        Quaternion quaternion = Quaternion.identity;
         Transform tran  = this.Spawn("EnemyOne", vector3, quaternion);
        tran.gameObject.SetActive(true);
    }
   */
    protected override void Awake()
    {
        base.Awake();
        EnemySpawner.instance = this;
    }
}
