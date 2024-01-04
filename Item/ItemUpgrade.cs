using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUpgrade : InventoryAbtract
{
    
    protected override void Start()
    {
        base.Start();
        this.Upgrade(0);
    }
    protected virtual bool Upgrade(int index)
    {
        if (index >= inventory.Items.Count) return false;
        ItemInventory item = inventory.Items[index];
        if (item.currentStack == 0) return false;
        List<ItemUpgradeInfo> itemUpgradeInfos = item.itemProfile.upgradeInfos;
        if (!this.Upgradeable(itemUpgradeInfos)) return false;
        if(!this.HaveEnoughIngredients(itemUpgradeInfos,item.currentLevel)) return false;
        this.DeductIngredients(itemUpgradeInfos,item.currentLevel);
        item.currentLevel++;
        return true;
    }
    protected virtual bool Upgradeable(List<ItemUpgradeInfo> itemUpgradeInfos)
    { 
        if(itemUpgradeInfos.Count == 0) return false;
        return true;
    }
    protected virtual bool HaveEnoughIngredients(List<ItemUpgradeInfo> itemUpgradeInfos, int level)
    {
        if(level > itemUpgradeInfos.Count) return false;
        ItemCodeEnum itemCode;
        int addCount;
        List<Ingredient> ingredients = itemUpgradeInfos[level].ingredients;
        foreach(Ingredient ingredient in ingredients)
        {
            itemCode = ingredient.itemProfileSO.itemCode;
            addCount = ingredient.count;
            if (!this.Enough(itemCode, addCount)) return false;
        }
        return true;
    }
    protected virtual bool Enough(ItemCodeEnum itemCode,int addCount)
    {
        int currentCount = 0;
        foreach(ItemInventory item in inventory.Items)
        {
            if (item.itemProfile.itemCode == itemCode) currentCount += item.currentStack;
        }
        if(currentCount < addCount) return false;
        return true;
    }
    protected virtual void DeductIngredients(List<ItemUpgradeInfo> itemUpgradeInfos,int level)
    {
        List<Ingredient> ingredients = itemUpgradeInfos[level].ingredients;
        foreach (Ingredient ingredient in ingredients)
        {
            int countRemain = ingredient.count;
            ItemCodeEnum itemCode = ingredient.itemProfileSO.itemCode;
            
                for(int i = inventory.Items.Count-1;i>=0; i--)
                {
                    ItemInventory item = inventory.Items[i];
                    if(item.itemProfile.itemCode == itemCode)
                    {
                        int temp = Mathf.Min(item.currentStack, countRemain);
                        item.currentStack -= temp;
                        countRemain -= temp;
                    
                }
            }
        }
    }
}
