using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementEvent : MonoBehaviour
{
    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<SoundManager>().Play("BasementEvent");
        light.GetComponent<Light>().color = new Color(0f, 1f, 1f, 0f);  //changes color to green
        gameObject.SetActive(false);
    }
}
