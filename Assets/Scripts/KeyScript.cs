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

        //if (isKey1)
        //{
        //    KeyHole.GetComponent<KeyHoleScript>().key1provided = true;
        //}
        
        //else if (isKey2)
        //{
        //    KeyHole.GetComponent<KeyHoleScript>().key2provided = true;
        //}
             

        //if (key1provided && key2provided)
        //{
        //  anim.setbool ("isOpened",true)
        //}

        //if (key1provided)
        //change color of light
        //key1complete = true;
        //if (key2provided)
        //change color of light
        //key2complete = true;

        //update completedKey()
        //if(key1complete & key2 complete)
        //anim.setbool("isOpened",true)


        UIpanel.SetActive(true);
        gameObject.SetActive(false);
    }

    public override void OnLoseFocus()
    {
        
    }
}
