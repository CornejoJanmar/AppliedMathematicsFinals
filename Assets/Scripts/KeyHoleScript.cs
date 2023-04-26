using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHoleScript : Interactable
{
    [SerializeField] GameObject light;
    [SerializeField] KeyHoleDoor LastDoor;
    [SerializeField] Animator anim;

    [SerializeField] public bool key1provided = false;
    [SerializeField] public bool key2provided = false;

    [SerializeField] private bool key1confirmed;
    [SerializeField] private bool key2confirmed;

    void Start()
    {
        LastDoor = GetComponent<KeyHoleDoor>();
    }

    public override void OnFocus()
    {

    }

    public override void OnInteract()
    {
        if (key1provided)
        {
            Debug.Log("Key 1 inserted");
            LastDoor.key1check = true;
            light.SetActive(true);
            light.GetComponent<Light>().color = new Color(0f, 1f, 1f, 0f);
        }

        if (key2provided)
        {
            Debug.Log("Key 2 inserted");
            LastDoor.key2check = true;
            light.SetActive(true);
            light.GetComponent<Light>().color = new Color(0f, 1f, 1f, 0f);
        }
    }

    public override void OnLoseFocus()
    {

    }
}
