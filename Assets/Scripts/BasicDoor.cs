using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDoor : Interactable
{
    [SerializeField] private bool isOpen = false;
    [SerializeField] public bool canBeInteracted = false;
    [SerializeField] private GameObject UIpanel;
    private Animator anim;
    [SerializeField] InventoryManager.AllItems itemRequired;
    public Canvas InteractTextPrompt;

    private void Start()
    {
        anim = GetComponent<Animator>();
        InteractTextPrompt.enabled = false;
    }

    public override void OnFocus()
    {
        InteractTextPrompt.enabled = true;
    }

    public override void OnInteract()
    {
        if (canBeInteracted)
        {
            isOpen = !isOpen;

            Vector3 doorTransformDir = transform.TransformDirection(Vector3.forward);
            Vector3 playerTransformDir = FirstPersonController.instance.transform.position - transform.position;
            float dot = Vector3.Dot(doorTransformDir, playerTransformDir);
            FindObjectOfType<SoundManager>().Play("Door");
            anim.SetFloat("dot", dot);
            anim.SetBool("isOpen", isOpen);
        }
        else if (!canBeInteracted)
        {
            if (HasRequiredItem(itemRequired))
            {
                canBeInteracted = true;
            }
            else
            {
                UIpanel.SetActive(true);
            }
        }
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

    public override void OnLoseFocus()
    {
        InteractTextPrompt.enabled = false;
    }


}
