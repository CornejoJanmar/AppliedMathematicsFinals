using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsate : MonoBehaviour
{
    private bool coroutineAllowed;

    private void Start()
    {
        coroutineAllowed = true;
    }

    private void Update()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("startPulsing");
        }
    }

    private IEnumerator startPulsing()
    {
        coroutineAllowed = false;

        for (float i = 0f; i <= 1f;i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 2f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 2f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 2f, Mathf.SmoothStep(0f, 1f, i))));
            yield return new WaitForSeconds(0.015f);
        }

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 2f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 2f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 2f, Mathf.SmoothStep(0f, 1f, i))));
            yield return new WaitForSeconds(0.015f);
        }

        coroutineAllowed = true;
    }
}
