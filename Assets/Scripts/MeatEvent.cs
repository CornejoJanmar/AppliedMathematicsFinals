using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatEvent : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<SoundManager>().Play("PullEvent");
        anim.SetBool("IsTriggered", true);
    }
}
