using Unity.VisualScripting;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private Camera safeCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        safeCamera.depth = -1;
    }
}
