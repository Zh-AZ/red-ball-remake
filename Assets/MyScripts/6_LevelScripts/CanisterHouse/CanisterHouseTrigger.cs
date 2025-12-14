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
        {
            //if (hasScrewdriver && hasHammer && hasBurglarKeys)
            //    t.text = "You have the screwdriver, hammer and tools keys to open the Canister House!";
            //else if (hasScrewdriver)
            //    t.text = "You have the screwdriver but need a hammer and tools keys to open the Canister House!";
            //else if (hasHammer)
            //    t.text = "You have the hammer but need a screwdriver and tools keys to open the Canister House!";
            //else if (hasBurglarKeys)
            //    t.text = "You have the tools keys but need a screwdriver and hammer to open the Canister House!";
            //else if ((hasScrewdriver && hasHammer && hasBurglarKeys) == false)
            //    t.text = "You need a screwdriver, hammer and tools keys to open the Canister House!";

            switch (hasScrewdriver, hasHammer, hasBurglarKeys)
            {
                case (true, true, true):
                    t.text = "You have the screwdriver, hammer and tools keys to open the Canister House!";
                    break;
                case (true, false, false):
                    t.text = "You have the screwdriver but need a hammer and tools keys to open the Canister House!";
                    break;
                case (false, true, false):
                    t.text = "You have the hammer but need a screwdriver and tools keys to open the Canister House!";
                    break;
                case (false, false, true):
                    t.text = "You have the tools keys but need a screwdriver and hammer to open the Canister House!";
                    break;
                case (true, true, false):
                    t.text = "You have the screwdriver and hammer but need tools keys to open the Canister House!";
                    break;
                case (true, false, true):
                    t.text = "You have the screwdriver and tools keys but need a hammer to open the Canister House!";
                    break;
                case (false, true, true):
                    t.text = "You have the hammer and tools keys but need a screwdriver to open the Canister House!";
                    break;
                case (false, false, false):
                    t.text = "You need a screwdriver, hammer and tools keys to open the Canister House!";
                    break;
            }

            t.gameObject.SetActive(true);
        }

        if (hasScrewdriver && hasHammer && hasBurglarKeys && Input.GetKeyDown(KeyCode.E))
        {
            canisterHouseDoor.SetTrigger("CanisterHouseOpenDoor");
            gameObject.SetActive(false);

            foreach (var t in interactText)
                t.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}
