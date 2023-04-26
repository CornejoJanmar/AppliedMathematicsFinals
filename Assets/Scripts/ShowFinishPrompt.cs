using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFinishPrompt : MonoBehaviour
{
    public Canvas GameFinishPrompt;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Player entered finish trigger");
            GameFinishPrompt.enabled = true;
        }
    }

    void Start()
    {
        GameFinishPrompt.enabled = false;
    }

    void Update()
    {
        
    }
}
