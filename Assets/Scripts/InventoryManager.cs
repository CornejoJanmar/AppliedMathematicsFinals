using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public List<AllItems> inventoryItems = new List<AllItems>();

    private void Awake()
    {
        instance = this;
    }

    public void addItem(AllItems item)
    {
        if (!inventoryItems.Contains(item))
        {
            inventoryItems.Add(item);
        }
    }

    public void removeItem(AllItems item)
    {
        if (inventoryItems.Contains(item))
        {
            inventoryItems.Remove(item);
        }
    }

    public enum AllItems
    {
        BasementKey,
        LeftKey,
        RightKey
    }
}
