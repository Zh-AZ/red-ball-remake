using TMPro;
using UnityEngine;

public class ScrewdriverTrigger : PlayerInventory
{
    [SerializeField] private GameObject screw;
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
            if (hasScrewdriver)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            text.text = "Press E to pick up the screwdriver";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasScrewdriver = true;
            screw.SetActive(false);

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
