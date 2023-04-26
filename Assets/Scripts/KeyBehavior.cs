using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : Interactable
{
    [SerializeField] InventoryManager.AllItems itemType;
    public Canvas InteractTextPrompt;

    public void Start()
    {
        InteractTextPrompt.enabled = false;
    }

    public override void OnFocus()
    {
        InteractTextPrompt.enabled = true;
    }

    public override void OnInteract()
    {
        InventoryManager.instance.addItem(itemType);
        Destroy(gameObject);
    }

    public override void OnLoseFocus()
    {
        InteractTextPrompt.enabled = false;
    }
}
