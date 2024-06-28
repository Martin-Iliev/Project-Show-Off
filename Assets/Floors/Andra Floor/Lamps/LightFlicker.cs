using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light lightSource; // Reference to the Light component
    public GameObject lightTarget;
    public float blinkDuration = 0.05f; // Duration for which the light will be off
    public int blinkCount = 3; // Number of times the light will blink
    public float interval = 3f; // Interval between each blink cycle

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();
        }
        StartCoroutine(BlinkLight());
    }

    IEnumerator BlinkLight()
    {
        while (true)
        {
            for (int i = 0; i < blinkCount; i++)
            {
                lightSource.enabled = false; // Turn off the light
                lightTarget.SetActive(false);
                yield return new WaitForSeconds(blinkDuration); // Wait for the blink duration
                lightSource.enabled = true; // Turn on the light
                lightTarget.SetActive(true);
                yield return new WaitForSeconds(blinkDuration); // Wait for the blink duration before next blink
            }
            yield return new WaitForSeconds(interval - (blinkCount * 2 * blinkDuration)); // Wait for the remaining interval time
        }
    }
}