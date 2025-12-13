using TMPro;
using UnityEngine;

public class CanisterHouseTrigger : PlayerInventory
{
    [SerializeField] private Animator canisterHouseDoor;
    [SerializeField] private TMP_Text[] interactText;

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
        foreach (var t in interactText)
            t.gameObject.SetActive(true);

        if (!hasScrewdriver && !hasHammer && !hasBurglarKeys)
        {
            foreach (var t in interactText)
                t.text = "You need a screwdriver, hammer and tools keys to open the Canister House!";
        }
        else if (hasScrewdriver && hasHammer && hasBurglarKeys && Input.GetKeyDown(KeyCode.E))
        {
            foreach (var t in interactText)
                t.text = "You have the screwdriver, hammer and tools keys to open the Canister House!";
            
            canisterHouseDoor.SetTrigger("CanisterHouseOpenDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}
