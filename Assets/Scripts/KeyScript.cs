using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : Interactable
{

    [SerializeField] GameObject DoorUnlocks;
    [SerializeField] private GameObject UIpanel;
    //bool isKey1
    //bool isKey2
    // GameObject DoorCube;

    public override void OnFocus()
    {
        
    }

    public override void OnInteract()
    {
        DoorUnlocks.GetComponent<BasicDoor>().canBeInteracted = true;

        //if(isKey1)
        //DoorCube.GetComponent<KeyHoleScript>().key1provided = true;
        //elseif(isKey2)
        //DoorCube.GetComponent<KeyHoleScript>().key2provided = true;      

        //if(key1provided && key2provided)
        //anim.setbool("isOpened",true)

        //if(key1provided)
        //change color  of light
        //key1complete = true;
        //if(key2provided)
        //change color  of light
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
