using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : Interactable
{
    [SerializeField] InventoryManager.AllItems itemType;

    public override void OnFocus()
    {
        
    }

    public override void OnInteract()
    {
        InventoryManager.instance.addItem(itemType);
        Destroy(gameObject);
    }

    public override void OnLoseFocus()
    {
        
    }
}
