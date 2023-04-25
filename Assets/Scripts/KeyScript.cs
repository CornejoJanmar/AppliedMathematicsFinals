using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : Interactable
{

    [SerializeField] GameObject DoorUnlocks;
    [SerializeField] private GameObject UIpanel;

    public override void OnFocus()
    {
        
    }

    public override void OnInteract()
    {
        DoorUnlocks.GetComponent<BasicDoor>().canBeInteracted = true;
        UIpanel.SetActive(true);
        gameObject.SetActive(false);
    }

    public override void OnLoseFocus()
    {
        
    }
}
