using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : Interactable
{
    public int keypadNumber = 1;

    public UnityEvent KeypadClicked;
    [SerializeField] GameObject light;

    public override void OnFocus()
    {
        light.SetActive(true);
    }

    public override void OnInteract()
    {
        KeypadClicked.Invoke();
    }

    public override void OnLoseFocus()
    {
        light.SetActive(false);
    }
}
