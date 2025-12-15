using TMPro;
using UnityEngine;

public class CanisterTrigger : PlayerInventory
{
    [SerializeField] private GameObject canister;
    [SerializeField] private TMP_Text[] interactionText;

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
        foreach (TMP_Text text in interactionText)
        {
            if (hasCanister)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            text.text = "Press E to take the canister";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            canister.SetActive(false);
            hasCanister = true;
            
            foreach (TMP_Text text in interactionText)
                text.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactionText)
            text.gameObject.SetActive(false);
    }
}
