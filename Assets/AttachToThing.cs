using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToThing : MonoBehaviour
{
    public void DisableController()
    {
        GameObject.FindWithTag("Controller").gameObject.SetActive(false);
    }
    public void AttachToController()
    {
        gameObject.transform.SetParent(GameObject.FindWithTag("Attach").gameObject.transform, true);
    }
}
