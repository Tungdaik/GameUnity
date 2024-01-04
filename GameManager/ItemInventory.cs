using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class ItemInventory 
{
    public ItemProfileSO itemProfile;
    public int currentStack;
    public int maxStack = 7;
    public int currentLevel = 0;

}
