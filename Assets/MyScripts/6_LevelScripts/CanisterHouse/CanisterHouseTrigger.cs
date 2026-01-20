using TMPro;
using UnityEngine;

public class CanisterHouseTrigger : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactText;
    [SerializeField] private Camera lockCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject originalLock;
    [SerializeField] private GameObject fakeLock;

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

            switch (HasItem("Screwdriver"), HasItem("Hammer"), HasItem("BurglarKeys"))
            {
                case (true, true, true):
                    t.text = "У вас есть все инструменты чтобы начать взлом замка";
                    break;
                case (true, false, false):
                    t.text = "У вас есть отвертка, нужны молоток и отмычки для взлома замка";
                    break;
                case (false, true, false):
                    t.text = "У вас есть молоток, нужны отвертка и отмычки для взлома замка";
                    break;
                case (false, false, true):
                    t.text = "У вас есть отмычки, нужны отвертка и молоток для взлома замка";
                    break;
                case (true, true, false):
                    t.text = "У вас есть отвертка и молоток, нужны отмычки для взлома замка";
                    break;
                case (true, false, true):
                    t.text = "У вас есть отвертка и отмычки, нужнен молоток для взлома замка!";
                    break;
                case (false, true, true):
                    t.text = "У вас есть молоток и отмычки, нужна отвертка для взлома замка";
                    break;
                case (false, false, false):
                    t.text = "Надо найти отвертку, молоток и отмычки чтобы взломать замок";
                    break;
            }

            t.gameObject.SetActive(true);
        }

        if (HasItem("Screwdriver") && HasItem("Hammer") && HasItem("BurglarKeys") && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);

            lockCamera.gameObject.SetActive(true);
            originalLock.SetActive(true);
            fakeLock.SetActive(false);
            player.SetActive(false);

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
