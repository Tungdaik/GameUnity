using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnRandom : SpawnRandom
{
    [SerializeField] GameCrl gameCrl;
    [SerializeField] protected float limit = 5;
    [SerializeField] protected float timePerObj;
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
        if (gameCrl.EnemyOneCount < limit)
        {
            Transform newTrans = this.spawnCrl.JunkSpawn.Spawn(newPrefab, newPos, newRot);
            newTrans.gameObject.SetActive(true);
            gameCrl.EnemyOneCount++;
        }
        Invoke(nameof(Spawn), timePerObj);

    }
}
