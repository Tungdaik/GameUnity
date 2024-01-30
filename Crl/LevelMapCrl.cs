using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMapCrl : TungMonoBehaviour
{
    [SerializeField] protected GameCrl gameCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected virtual void LoadCrl()
    {
        this.gameCrl = transform.parent.GetComponent<GameCrl>();
    }
    protected virtual void UpgradeMap()
    {

    }
}
