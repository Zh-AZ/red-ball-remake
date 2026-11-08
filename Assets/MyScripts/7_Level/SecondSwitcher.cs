using UnityEngine;

public class SecondSwitcher : DoorSwitcher
{
    [SerializeField] private bool isOpen;
    
    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            StartCoroutine(OpenDoor_1());
        }
    }
}
