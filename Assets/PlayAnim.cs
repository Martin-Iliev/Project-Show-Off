using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class PlayAnim : MonoBehaviour
{
    public Animator[] anims;
    public Animator chase;
    public GameObject rayInteractor;
    public bool isWendigo = false;
    private GameObject headset;

    private void OnBecameVisible()
    {
        if (isWendigo)
        {
            PlayAnimation1();
        }
    }

    public void CutToBlack()
    {
        headset = GameObject.FindWithTag("headset");
        if (headset != null)
        {
            headset.SetActive(false);
        }
    }
    public void SetTrigger1(string triggerName)
    {
        if (chase != null)
        {
            chase.SetTrigger(triggerName);
        }
    }
    public void DisableRayInteractor()
    {
        if (rayInteractor != null)
        {
            rayInteractor.SetActive(false);
        }
    }
    public void EnableRayInteractor()
    {
        if (rayInteractor != null)
        {
            rayInteractor.SetActive(true);
        }
    }
    public void StartAnimation1()
    {
        anims[0].enabled = true;
    }
    public void PlayAnimation1()
    {
        anims[0].enabled = true;
    }
    public void PauseAnimation1()
    {
        anims[0].enabled = false;
    }
    public void StartAnimation2()
    {
        anims[1].enabled = true;
    }
    public void PlayAnimation2()
    {
        anims[1].enabled = true;
    }
    public void PauseAnimation2()
    {
        anims[1].enabled = false;
    }
    public void StartAnimation3()
    {
        anims[2].enabled = true;
    }
    public void PlayAnimation3()
    {
        anims[2].enabled = true;
    }
    public void PauseAnimation3()
    {
        anims[2].enabled = false;
    }

    public void StartAnimation4()
    {
        anims[3].enabled = true;
    }
}

