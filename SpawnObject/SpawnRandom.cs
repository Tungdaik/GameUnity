using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : TungMonoBehaviour
{
    [SerializeField] protected SpawnCrl spawnCrl;
   
   
    
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadController();
    }
    protected override void Start()
    {
        base.Start();
        this.Spawn();
    }
    protected virtual void LoadController()
    {  if (spawnCrl != null) return;
        this.spawnCrl = transform.GetComponent<SpawnCrl>();
    }
    protected virtual void Spawn()
    {
       
        Transform newRandom = this.spawnCrl.JunkRandom.GetRandomPoint();
        Vector3 newPos = newRandom.position;
        Quaternion newRot = transform.rotation;
        Transform newPrefab = this.spawnCrl.JunkSpawn.GetRandomPrefab();
         Transform newTrans = this.spawnCrl.JunkSpawn.Spawn(newPrefab, newPos, newRot);
         newTrans.gameObject.SetActive(true);
        Invoke(nameof(Spawn), 1.5f);
    }
}
