using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextPrompt : MonoBehaviour
{
    // went for a basic on/off collider switch

    public GameObject InteractTextPrompt;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            InteractTextPrompt.SetActive(true);
            Destroy(gameObject);
        }
    }
}
