using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRandom : TungMonoBehaviour
{
    [SerializeField] protected JunkSpawnCrl junkCrl;
    
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
    {  if (junkCrl != null) return;
        this.junkCrl = Transform.FindObjectOfType<JunkSpawnCrl>();
    }
    protected virtual void SpawnRandom()
    {
        Transform newRandom = this.junkCrl.JunkRandom.GetRandomPoint();
        Vector3 newPos = newRandom.position;
        Quaternion newRot = transform.rotation;
         Transform newTrans = this.junkCrl.JunkSpawn.Spawn("JunkOne", newPos, newRot);
         newTrans.gameObject.SetActive(true);
        Invoke(nameof(SpawnRandom), 1f);
    }
}
