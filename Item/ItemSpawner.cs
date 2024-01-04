using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : Spawner
{
    [SerializeField] protected static ItemSpawner instance;
    public static ItemSpawner Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        ItemSpawner.instance = this;
    }
    public virtual void Drop(List<DropRate> dropRates,Vector3 pos,Quaternion ros)
    {
        ItemCodeEnum itemCode = dropRates[0].itemProfileSO.itemCode;
        Transform newItem = this.Spawn(itemCode.ToString(), pos, ros);
        newItem.gameObject.SetActive(true);
    }
    public virtual void Drop(ItemCodeEnum itemCode,int currentLevel,Vector3 pos,Quaternion ros) {
        Transform newItem = this.Spawn(itemCode.ToString(), pos, ros);
        newItem.gameObject.SetActive(true);
        ItemCrl itemCrl = newItem.GetComponent<ItemCrl>();
        itemCrl.SetLevel(currentLevel);
       
    }
}
