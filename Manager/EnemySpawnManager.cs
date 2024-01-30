using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : TungMonoBehaviour
{
    [SerializeField] protected EnemyCrl enemyCrl;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCrl();
    }
    protected virtual void LoadCrl()
    {
        this.enemyCrl = Transform.FindObjectOfType<EnemyCrl>();
    }
}
