using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandomPoints : TungMonoBehaviour
{
    [SerializeField] protected List<Transform> randomPoints;
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadPoint();
    }
    protected virtual void LoadPoint()
    {
        if (randomPoints.Count > 0) return;
        foreach(Transform t in transform)
        {
            this.randomPoints.Add(t);
        }
    }
    public virtual Transform GetRandomPoint()
    {
        int rand = Random.Range(0, randomPoints.Count);
        return this.randomPoints[rand];
    }
}
