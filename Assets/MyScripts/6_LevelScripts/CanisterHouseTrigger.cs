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
        if (this.hasSkeletonKeys == false)
        {
            Debug.Log("You haven't the skeleton keys!");
        }
        else if (this.hasSkeletonKeys == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You open Canister House door!");
            canisterHouseDoor.SetTrigger("CanisterHouseOpenDoor");
        }
    }
}
