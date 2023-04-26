using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalKeyScript : Interactable
{
    [SerializeField] GameObject KeyHole;
    [SerializeField] Animator anim;

    [SerializeField] private bool isKey1;
    [SerializeField] private bool isKey2;

    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {

        if (isKey1)
        {
            KeyHole.GetComponent<KeyHoleScript>().key1provided = true;
        }

        if (isKey2)
        {
            KeyHole.GetComponent<KeyHoleScript>().key2provided = true;
        }

        gameObject.SetActive(false);
    }

    public override void OnLoseFocus()
    {

    }
}
