using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRandom : SpawnRandom
{
    [SerializeField] GameCrl gameCrl;
    [SerializeField] protected float limit = 40;
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
        if (this.gameCrl.JunkCount >= limit) return;
        this.gameCrl.JunkCount++;
        base.Spawn();
    }
}
