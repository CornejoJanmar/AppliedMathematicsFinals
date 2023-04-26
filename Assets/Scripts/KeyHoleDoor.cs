using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHoleDoor : MonoBehaviour
{
    [SerializeField] Animator anim;

    public bool key1check;
    public bool key2check;

    void Update()
    {
        if (key1check && key2check)
        {
            anim.SetBool("IsOpened", true);
        }
    }
}
