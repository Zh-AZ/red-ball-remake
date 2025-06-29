using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChecker : MonoBehaviour
{
    [SerializeField] private GameObject[] menuCanvases; // Array to hold menu canvases
    [SerializeField] private GameObject playerComponents; // Reference to player components

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuCanvases[0].activeSelf && !menuCanvases[1].activeSelf && playerComponents.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
