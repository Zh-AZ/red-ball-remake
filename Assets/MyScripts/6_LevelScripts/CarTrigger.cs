using TMPro;
using UnityEngine;

public class CarTrigger : PlayerInventory
{
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
        foreach (TMP_Text text in interactText)
        {
            if (HasItem("CanisterFuel"))
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            if (HasItem("Canister") && HasItem("Hose"))
            {
                text.text = "Press E to refuel the car";
            }
            else if (HasItem("Canister"))
            {
                text.text = "You need a hose to refuel the car";
            }
            else if (HasItem("Hose"))
            {
                text.text = "You need a canister to refuel the car";
            }
            else
            {
                text.text = "You need a canister and a hose to refuel the car";
            }
        }

        if (HasItem("Canister") && HasItem("Hose") && Input.GetKeyDown(KeyCode.E))
        {
            AddItem("CanisterFuel");
            //hasCanisterFuel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
