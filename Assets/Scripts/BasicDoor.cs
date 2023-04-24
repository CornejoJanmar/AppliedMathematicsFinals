using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDoor : Interactable
{
    [SerializeField] private bool isOpen = false;
    [SerializeField] private bool canBeInteracted = false;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override void OnFocus()
    {

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
            //UI show "Door is Locked"
            //UI show "There must be a key somewhere"
        }
    }

    public override void OnLoseFocus()
    {
        
    }


}
