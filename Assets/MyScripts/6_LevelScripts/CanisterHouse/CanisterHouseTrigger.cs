using UnityEngine;

public class CanisterHouseTrigger : PlayerInventory
{
    [SerializeField] private Animator canisterHouseDoor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (!hasScrewdriver && !hasHammer && !hasBurglarKeys)
        {
            Debug.Log("You haven't the tools keys!");
        }
        else if (hasScrewdriver && hasHammer && hasBurglarKeys && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You open Canister House door!");
            canisterHouseDoor.SetTrigger("CanisterHouseOpenDoor");
        }
    }
}
