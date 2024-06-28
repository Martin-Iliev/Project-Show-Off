using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutToBlack : MonoBehaviour
{
    public Image blackImage; // Drag the black image here in the inspector

    void Start()
    {
        if (blackImage != null)
        {
            // Ensure the black image is initially hidden
            blackImage.enabled = false;
        }
        else
        {
            Debug.LogError("Black Image is not assigned in the inspector.");
        }
    }

    public void ShowBlackScreen()
    {
        if (blackImage != null)
        {
            blackImage.enabled = true;
        }
    }

    public void HideBlackScreen()
    {
        if (blackImage != null)
        {
            blackImage.gameObject.SetActive(false);
        }
    }
}