using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnRandom : SpawnRandom
{
    [SerializeField] GameCrl gameCrl;
    
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadGameCrl();
    }
    protected virtual void LoadGameCrl()
    {
        this.gameCrl = Transform.FindObjectOfType<GameCrl>();
    }
    protected override void Spawn()
    {

        Transform newRandom = this.spawnCrl.JunkRandom.GetRandomPoint();
        Vector3 newPos = newRandom.position;
        Quaternion newRot = transform.rotation;
        Transform newPrefab = this.spawnCrl.JunkSpawn.GetRandomPrefab();
        if (newPrefab.name == "UFO" && gameCrl.UFOCount < gameCrl.LimitedUFO) this.SpawnUFO(newPrefab,newPos,newRot);
        if (newPrefab.name == "EnemyOne"&& gameCrl.EnemyOneCount < gameCrl.LimitedEnemyOne) this.SpawnEnemyOne(newPrefab, newPos, newRot);
        
        Invoke(nameof(Spawn), gameCrl.TimePerObj);

    }
    protected virtual void SpawnUFO(Transform newPrefab,Vector3 newPos,Quaternion newRot)
    {
        Transform newTrans = this.spawnCrl.JunkSpawn.Spawn(newPrefab, newPos, newRot);
        newTrans.gameObject.SetActive(true);
        gameCrl.UFOCount++;
    }
    protected virtual void SpawnEnemyOne(Transform newPrefab, Vector3 newPos, Quaternion newRot) { 
        Transform newTrans = this.spawnCrl.JunkSpawn.Spawn(newPrefab, newPos, newRot);
        newTrans.gameObject.SetActive(true);
        gameCrl.EnemyOneCount++;
    }
}
