using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffLight : MonoBehaviour
{
    public GameObject lightl;
    public void removeLight()
    {
        lightl.SetActive(false);
    }
}
