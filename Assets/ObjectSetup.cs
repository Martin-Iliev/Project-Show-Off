using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetup : MonoBehaviour
{
    // Public field to assign the object from the inspector
    public GameObject flashLight;
    public float offDuration = 0.1f;

    public GameObject targetObjects1;
    public GameObject targetObjects2;
    public GameObject targetObjects3;
    public GameObject prepareJumpscare;
    public GameObject Jumpscare;
    private GameObject headset;

    // Private field to reference the AudioSource component
    public AudioSource monsterWail;
    public AudioSource twigSnap;
    public AudioSource monsterWheeze;
    public AudioSource jumpscareSound;
    public GameObject ambiance;

    public void TurnOffLight()
    {
        if (flashLight != null)
        {
            StartCoroutine(TurnOffLightCoroutine(offDuration));
        }
    }

    private IEnumerator TurnOffLightCoroutine(float duration)
    {
        // Turn off the light
        flashLight.SetActive(false);

        // Wait for the specified duration
        yield return new WaitForSeconds(duration);

        // Turn the light back on
        flashLight.SetActive(true);
    }

    public void PlayWail()
    {
        if (monsterWail != null)
        {
            monsterWail.Play();
        }
    }

    public void PlayTwig()
    {
        if (twigSnap != null)
        {
            twigSnap.Play();
        }
    }
    public void PlayWheeze()
    {
        if (monsterWheeze != null)
        {
            monsterWheeze.Play();
        }
    }
    public void PlayJumpscare()
    {
        if (jumpscareSound != null)
        {
            jumpscareSound.Play();
        }
    }

    public void StopAmbiance()
    {
        if (ambiance != null)
        {
            ambiance.SetActive(false);
        }
    }
    

    // Method to show the object (enable it)
    public void ShowObjects1()
    {
        if (targetObjects1 != null)
        {
            targetObjects1.SetActive(true);
        }
    }

    public void ShowObjects2()
    {
        if (targetObjects2 != null)
        {
            targetObjects2.SetActive(true);
        }
    }

    public void ShowObjects3()
    {
        if (targetObjects3 != null)
        {
            targetObjects3.SetActive(true);
        }
    }

    public void PrepareJumpscare()
    {
        if (prepareJumpscare != null)
        {
            prepareJumpscare.SetActive(true);
        }
    }
    public void ShowJumpscare()
    {
        if (Jumpscare != null)
        {
            Jumpscare.SetActive(true);
        }
    }
}
