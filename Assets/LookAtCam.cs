using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    private GameObject cam;
    [SerializeField] bool onlyY = false;

    void Update()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        if (cam != null)
        {
            if (!onlyY)
            {
                // Make the object look at the main camera
                transform.LookAt(cam.transform);
            }
            if (onlyY)
            {
                Vector3 direction = cam.transform.position - transform.position;
                direction.y = 0;
                if (direction != Vector3.zero)
                {
                    // Calculate the rotation needed to look in the direction
                    Quaternion rotation = Quaternion.LookRotation(direction);

                    // Apply the rotation to the object
                    transform.rotation = rotation;
                }
            }
        }
    }
}
