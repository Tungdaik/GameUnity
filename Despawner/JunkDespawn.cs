using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
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
    public override void DespawnObject()
    {
        gameCrl.JunkCount--;
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
