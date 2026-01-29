using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorChecker : MonoBehaviour
{
    [SerializeField] private GameObject[] menuCanvases; 
    [SerializeField] private GameObject playerComponents;
    [SerializeField] private Camera safeCamera;

    /// <summary>
    /// Скрыть курсор в игре, если не открыто меню
    /// </summary>
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
