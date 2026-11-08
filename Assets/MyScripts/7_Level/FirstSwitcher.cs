using UnityEngine;

public class FirstSwitcher : DoorSwitcher
{
    [SerializeField] private bool isOpen;
    
    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            StartCoroutine(OpenDoor_3());
        }
    }
}
