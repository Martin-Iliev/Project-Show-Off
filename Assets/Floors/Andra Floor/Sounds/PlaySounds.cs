using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public AudioSource papers;
    public AudioSource step;
    public AudioSource breathing;
    public AudioSource slam;

    public void PlayPapers()
    {
        papers.Play();
    }

    public void StopPapers() {
        papers.Stop();
    }

    public void PlayStep()
    {
        step.Play();
    }

    public void PlayBreathing()
    {
        breathing.Play();
    }

    public void StopBreathing() 
    {
        breathing.Stop(); 
    }

    public void PlaySlam()
    {
        slam.Play();
    }
}
