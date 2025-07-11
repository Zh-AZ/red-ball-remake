using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] private Camera[] cameras;

    public void CameraSwitch()
    {
        if (cameras[0].gameObject.activeSelf)
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        else if (cameras[1].gameObject.activeSelf)
        {
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(true);
        }
        else 
        {
            cameras[2].gameObject.SetActive(false);
            cameras[0].gameObject.SetActive(true);
        }
    }
}
