using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatEvent : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsTriggered", true);
    }
}
