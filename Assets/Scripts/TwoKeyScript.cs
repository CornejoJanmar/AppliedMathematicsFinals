using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoKeyScript : Interactable
{
    [SerializeField] InventoryManager.AllItems itemRequired;
    [SerializeField] GameObject light;
    [SerializeField] public bool IsInserted;

    public override void OnFocus()
    {
        
    }

    public override void OnInteract()
    {
        if (HasRequiredItem(itemRequired))
        {
            light.GetComponent<Light>().color = new Color(0f, 1f, 1f, 0f);
            Debug.Log("Key Inserted");
            IsInserted = true;
        }
    }

    public override void OnLoseFocus()
    {
        
    }

    public bool HasRequiredItem(InventoryManager.AllItems itemRequired)
    {
        if (InventoryManager.instance.inventoryItems.Contains(itemRequired))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
