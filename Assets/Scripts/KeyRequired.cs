using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRequired : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] GameObject key1System;
    [SerializeField] GameObject key2System;
    [SerializeField] TwoKeyScript key1Script;
    [SerializeField] TwoKeyScript key2Script;

    private void Start()
    {
        key1Script = key1System.GetComponent<TwoKeyScript>();
        key2Script = key2System.GetComponent<TwoKeyScript>();
    }

    public void Update()
    {
        if (key1Script.IsInserted & key2Script.IsInserted)
        {
            anim.SetBool("IsOpened", true);
        }
    }

}
