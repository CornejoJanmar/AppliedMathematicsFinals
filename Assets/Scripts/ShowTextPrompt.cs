using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextPrompt : MonoBehaviour
{
    // went for a basic on/off collider switch

    public Canvas InteractTextPrompt;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Player entered text trigger");
            InteractTextPrompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Player has left the text trigger");
            InteractTextPrompt.enabled = false;
        }
    }

    void Start()
    {
        InteractTextPrompt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
