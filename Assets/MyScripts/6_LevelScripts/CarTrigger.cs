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
            if (hasCanisterFuel)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            if (hasCanister && hasHose)
            {
                text.text = "Press E to refuel the car";
            }
            else if (hasCanister)
            {
                text.text = "You need a hose to refuel the car";
            }
            else if (hasHose)
            {
                text.text = "You need a canister to refuel the car";
            }
            else
            {
                text.text = "You need a canister and a hose to refuel the car";
            }
        }

        if (hasCanister && hasHose && Input.GetKeyDown(KeyCode.E))
        {
            hasCanisterFuel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
