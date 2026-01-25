using Unity.VisualScripting;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private Camera safeCamera;

    public void OnButtonClick()
    {
        safeCamera.depth = -1;
    }
}
