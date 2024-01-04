using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRandom : TungMonoBehaviour
{
    [SerializeField] protected JunkSpawnCrl junkSpawnCrl;
    
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadController();
    }
    protected override void Start()
    {
        base.Start();
        this.SpawnRandom();
    }
    protected virtual void LoadController()
    {  if (junkSpawnCrl != null) return;
        this.junkSpawnCrl = Transform.FindObjectOfType<JunkSpawnCrl>();
    }
    protected virtual void SpawnRandom()
    {
        Transform newRandom = this.junkSpawnCrl.JunkRandom.GetRandomPoint();
        Vector3 newPos = newRandom.position;
        Quaternion newRot = transform.rotation;
        Transform newPrefab = this.junkSpawnCrl.JunkSpawn.GetRandomPrefab();
         Transform newTrans = this.junkSpawnCrl.JunkSpawn.Spawn(newPrefab, newPos, newRot);
         newTrans.gameObject.SetActive(true);
        Invoke(nameof(SpawnRandom), 1f);
    }
}
