using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public abstract class Spawner : TungMonoBehaviour
{
    [SerializeField] protected  List<Transform> prefabs;
    [SerializeField] protected Transform holder;
    [SerializeField] protected List<Transform> poolObjects;
    
    
    protected override void Reset()
    {
        this.LoadCompoments();
    }
   
    protected override void LoadCompoments()
    {
        this.LoadPrefabsList();
        this.LoadPool();
    }
    protected virtual void LoadPrefabsList()
    {   if (prefabs.Count > 0) return;
        Transform prefobs = this.transform.Find("Prefabs");
        foreach (Transform prefab in prefobs) { 
            prefabs.Add(prefab);
        }
        this.SetActive();
    }
    protected virtual void LoadPool()
    {
        this.holder = this.transform.Find("Pool");

    }
    protected virtual void SetActive()
    {
        foreach (Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
    public virtual Transform Spawn(string prefabName,Vector3 spawnPos,Quaternion spawnRot)
    {
        Transform pref = this.GetPrefabFromText(prefabName);
        Transform newPrefab = this.GetPrefabFromPool(pref);
        newPrefab.SetPositionAndRotation(spawnPos, spawnRot);
        newPrefab.parent = this.holder;
        return newPrefab;
    }
    protected virtual Transform GetPrefabFromText(string text)
    {
       foreach(Transform prefab in this.prefabs)
        {
            if(prefab.name == text) return prefab;
        }
       return null;
    }
    protected virtual Transform GetPrefabFromPool(Transform trans)
    {
        foreach(Transform poolobject in poolObjects)
        {
            if(poolobject.name == trans.name)
            {
               poolObjects.Remove(poolobject);
                
                return poolobject;
            }
        }
        Transform prefabObject = Instantiate(trans);
        prefabObject.name = trans.name;
        return prefabObject;
    }
     public virtual void Despawn(Transform obj)
    {
        this.poolObjects.Add(obj);
        obj.gameObject.SetActive(false);
    }
}
