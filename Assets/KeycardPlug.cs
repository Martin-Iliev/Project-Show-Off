using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardPlug : MonoBehaviour
{
    public Animator anim;
    public GameObject button;
    void Start()
    {
        
        if (anim == null)
        {
            //Debug.LogError("Animator component not found on the object.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("keycardHole"))
        {
            if (anim != null)
            {
                anim.enabled = true;
                gameObject.SetActive(false);
            }
        }
        if (other.CompareTag("buttonHole"))
        {
            gameObject.SetActive(false);
            button.SetActive(true);
        }
    }
}