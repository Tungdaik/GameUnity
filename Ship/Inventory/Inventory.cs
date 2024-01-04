using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : TungMonoBehaviour
{
    [SerializeField] protected int maxSlot = 70;
    [SerializeField] protected List<ItemInventory> items;
    public List<ItemInventory> Items { get { return items; } }
    protected override void Start()
    {
        base.Start();
        //this.Add(ItemCodeEnum.Iron, 40);
    }
   
    public virtual bool Add(ItemCodeEnum itemCode,int addCount,int currentLevel)
    {
        int addRemain = addCount;
        while (addRemain > 0)
        {
            ItemInventory addItem = this.GetItemByCode(itemCode,currentLevel);
            addItem.currentLevel = currentLevel;
            int newCount = Mathf.Min(7 - addItem.currentStack, addRemain)+addItem.currentStack;
            addRemain -= newCount;
            addItem.currentStack = newCount;
        }
        if(addRemain > 0) return false; 
        return true;
    }
    protected virtual ItemInventory GetItemByCode(ItemCodeEnum itemCode,int currentLevel)
    {
        foreach(ItemInventory item in items)
        {
            if(item.itemProfile.itemCode == itemCode&&item.currentStack < 7 && item.currentLevel == currentLevel) return item;
        }
        return this.GetNewItem(itemCode,currentLevel);
    }
    protected virtual ItemInventory GetNewItem(ItemCodeEnum itemCode,int currentLevel)
    {
        var profiles = Resources.LoadAll("ItemProfiles", typeof(ItemProfileSO));
        foreach(ItemProfileSO profile in profiles)
        {
            if (profile.itemCode != itemCode) continue;
            ItemInventory item = new ItemInventory();
            item.itemProfile = profile;
            item.currentStack = 0;
            item.maxStack = 7;
            item.currentLevel = currentLevel;
            items.Add(item);
            return item;
        }
        return null;
    }
}
